using LoncotesLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<LoncotesLibraryDbContext>(builder.Configuration["LoncotesLibraryDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/api/materials", (LoncotesLibraryDbContext db, int? materialTypeId, int? genreId) =>
{
    if (materialTypeId != null && genreId != null)
    {
        List<Material> matchedMaterials = db.Materials.Where(m => m.MaterialTypeId == materialTypeId && m.GenreId == genreId).Include(m => m.MaterialType).Include(g => g.Genre).ToList();

        if (matchedMaterials.Count > 0)
        {
            return Results.Ok(matchedMaterials);
        }
        else 
        {
            return Results.NotFound();
        }
    }
    if (materialTypeId != null && genreId == null)
    {
        List<Material> matchedMaterials = db.Materials.Where(m => m.MaterialTypeId == materialTypeId).Include(m => m.MaterialType).Include(g => g.Genre).ToList();

        if (matchedMaterials.Count > 0)
        {
            return Results.Ok(matchedMaterials);
        }
        else 
        {
            return Results.NotFound();
        }
    }
    if (materialTypeId == null && genreId != null)
    {
        List<Material> matchedMaterials = db.Materials.Where(m => m.GenreId == genreId).Include(m => m.MaterialType).Include(g => g.Genre).ToList();

        if (matchedMaterials.Count > 0)
        {
            return Results.Ok(matchedMaterials);
        }
        else 
        {
            return Results.NotFound();
        }
    }
    return Results.Ok(db.Materials.Where(m => m.OutOfCirculationSince == null).Include(m => m.MaterialType).Include(g => g.Genre).ToList());

});

app.MapGet("/api/materials/{id}", (LoncotesLibraryDbContext db, int id) =>
{
    return db.Materials.Where(m => m.Id == id).Include(m => m.Genre).Include(m => m.MaterialType).Include(m => m.Checkouts).ThenInclude(m => m.Patron).ToList();
});

app.MapGet("/api/materials/available", (LoncotesLibraryDbContext db) =>
{
    return db.Materials
    .Where(m => m.OutOfCirculationSince == null)
    .Where(m => m.Checkouts.All(co => co.ReturnDate != null))
    .ToList();
});

app.MapPost("/api/materials", (LoncotesLibraryDbContext db, Material material) =>
{
    db.Materials.Add(material);
    db.SaveChanges();
    return Results.Created($"/api/materials/{material.Id}", material);
});

app.MapPut("/api/materials/{id}", (LoncotesLibraryDbContext db, int id) =>
{
    Material matchedMaterial = db.Materials.Single(m => m.Id == id);

    matchedMaterial.OutOfCirculationSince = DateTime.Now;

    db.SaveChanges();
    return Results.NoContent();
});


app.MapGet("/api/materialtypes", (LoncotesLibraryDbContext db) =>
{
    return Results.Ok(db.MaterialTypes.ToList());
});

app.MapGet("/api/genres", (LoncotesLibraryDbContext db) =>
{
    return Results.Ok(db.Genres.ToList());
});

app.MapGet("/api/patrons", (LoncotesLibraryDbContext db) =>
{
    return Results.Ok(db.Patrons.ToList());
});

app.MapGet("/api/patrons/{id}", (LoncotesLibraryDbContext db, int id) =>
{
    return Results.Ok(db.Patrons.Where(p => p.Id == id).Include(p => p.Checkouts).ThenInclude(c => c.material).ThenInclude(m => m.MaterialType));

});


app.MapPut("/api/patrons/{id}", (LoncotesLibraryDbContext db, int id, Patron updatedPatron) =>
{
    Patron matchedPatron = db.Patrons.Single(p => p.Id == id);

    matchedPatron.Address = updatedPatron.Address;
    matchedPatron.Email = updatedPatron.Email;

    db.SaveChanges();

    return Results.NoContent();
});

app.MapPut("/api/patrons/{id}/deactivate", (LoncotesLibraryDbContext db, int id) =>
{
    Patron matchedPatron = db.Patrons.Single(p => p.Id == id);

    matchedPatron.IsActive = false;

    db.SaveChanges();

    return Results.NoContent();
});

app.MapPost("/api/checkouts", (LoncotesLibraryDbContext db, Checkout newCheckout) =>
{
    newCheckout.CheckoutDate =  DateTime.Today;
    newCheckout.material = db.Materials.SingleOrDefault(m => m.Id == newCheckout.MaterialId);
    newCheckout.Patron = db.Patrons.SingleOrDefault(p => p.Id == newCheckout.PatronId);
    db.Checkouts.Add(newCheckout);
    db.SaveChanges();
    return Results.Created($"/api/checkouts/{newCheckout.Id}", newCheckout);
});

app.MapPut("/api/checkouts/{id}/return", (LoncotesLibraryDbContext db, int id) =>
{
    Checkout foundCheckout = db.Checkouts.SingleOrDefault(c => c.Id == id);
    foundCheckout.ReturnDate = DateTime.Now;
    db.SaveChanges();
    return Results.NoContent();
});

app.MapGet("/api/checkouts/overdue", (LoncotesLibraryDbContext db) =>
{
    return db.Checkouts
    .Include(co => co.Patron)
    .Include(co => co.material)
    .ThenInclude(m => m.MaterialType)
    .Where(co => (DateTime.Today - co.CheckoutDate).Days > co.material.MaterialType.CheckoutDays && co.ReturnDate == null)
    .ToList();
    
});

app.Run();