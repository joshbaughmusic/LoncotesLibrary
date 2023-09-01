using LoncotesLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;

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

app.MapPost("/api/materials", (LoncotesLibraryDbContext db, Material material) =>
{
    db.Materials.Add(material);
    db.SaveChanges();
    return Results.Created($"/api/materials/{material.Id}", material);
});

app.Run();
