using Microsoft.EntityFrameworkCore;
using LoncotesLibrary.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class LoncotesLibraryDbContext : DbContext
{
    public DbSet<Checkout> Checkouts { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<MaterialType> MaterialTypes { get; set; }
    public DbSet<Patron> Patrons { get; set; }

    public LoncotesLibraryDbContext(DbContextOptions<LoncotesLibraryDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>().HasData(new Material[]
        {
            new Material {Id = 1, MaterialName = "1984", MaterialTypeId = 1, GenreId = 1, OutOfCirculationSince = null},
            // Instance 2
            new Material { Id = 2, MaterialName = "The Lord of the Rings", MaterialTypeId = 1, GenreId = 2, OutOfCirculationSince = null},

            // Instance 3
            new Material { Id = 3, MaterialName = "The Matrix", MaterialTypeId = 2, GenreId = 3, OutOfCirculationSince = null },

            // Instance 4
            new Material { Id = 4, MaterialName = "The Shining", MaterialTypeId = 1, GenreId = 4, OutOfCirculationSince = new DateTime(1992, 04, 10) },

            // Instance 5
            new Material { Id = 5, MaterialName = "Pulp Fiction", MaterialTypeId = 2, GenreId = 5, OutOfCirculationSince = null },

            // Instance 6
            new Material { Id = 6, MaterialName = "The Catcher in the Rye", MaterialTypeId = 1, GenreId = 1, OutOfCirculationSince = new DateTime(2002, 09, 18) },

            // Instance 7
            new Material { Id = 7, MaterialName = "Blade Runner", MaterialTypeId = 2, GenreId = 2, OutOfCirculationSince = null },

            // Instance 8
            new Material { Id = 8, MaterialName = "War Of The Worlds", MaterialTypeId = 3, GenreId = 2, OutOfCirculationSince = null },

            // Instance 9
            new Material { Id = 9, MaterialName = "Brave New World", MaterialTypeId = 1, GenreId = 4, OutOfCirculationSince = null },

            // Instance 10
            new Material { Id = 10, MaterialName = "Star Wars: A New Hope", MaterialTypeId = 2, GenreId = 5, OutOfCirculationSince = new DateTime(2007, 03, 27) },

            // Instance 11
            new Material { Id = 11, MaterialName = "Master of Puppets", MaterialTypeId = 3, GenreId = 1, OutOfCirculationSince = null },

            // Instance 12
            new Material { Id = 12, MaterialName = "The Hobbit", MaterialTypeId = 1, GenreId = 2, OutOfCirculationSince = null },

            // Instance 13
            new Material { Id = 13, MaterialName = "The Terminator", MaterialTypeId = 2, GenreId = 3, OutOfCirculationSince = new DateTime(1998, 06, 08) },

            // Instance 14
            new Material { Id = 14, MaterialName = "Ride the Lightning", MaterialTypeId = 3, GenreId = 4, OutOfCirculationSince = null },

            // Instance 15
            new Material { Id = 15, MaterialName = "Jurassic Park", MaterialTypeId = 1, GenreId = 5, OutOfCirculationSince = new DateTime(2004, 10, 22) }
        });

        modelBuilder.Entity<MaterialType>().HasData(new MaterialType []
        {
            new MaterialType { Id = 1, Name = "Book", CheckoutDays = 14},
            new MaterialType { Id = 2, Name = "Movie", CheckoutDays = 3},
            new MaterialType { Id = 3, Name = "CD", CheckoutDays = 7}
        });

        modelBuilder.Entity<Genre>().HasData(new Genre []
        {
            new Genre { Id = 1, Name = "Horror"},
            new Genre { Id = 2, Name = "SciFi"},
            new Genre { Id = 3, Name = "Action"},
            new Genre { Id = 4, Name = "Metal"},
            new Genre { Id = 5, Name = "Thriller"}
        });

        modelBuilder.Entity<Patron>().HasData(new Patron []
        {
            // Patron 1
            new Patron
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                Email = "johndoe@example.com",
                IsActive = true
            },

            // Patron 2
            new Patron
            {
                Id = 2,
                FirstName = "Alice",
                LastName = "Smith",
                Address = "456 Elm St",
                Email = "alicesmith@example.com",
                IsActive = true
            },

            // Patron 3
            new Patron
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Johnson",
                Address = "789 Oak St",
                Email = "bobjohnson@example.com",
                IsActive = false
            },

            // Patron 4
            new Patron
            {
                Id = 4,
                FirstName = "Emily",
                LastName = "Wilson",
                Address = "101 Pine St",
                Email = "emilywilson@example.com",
                IsActive = true
            },

            // Patron 5
            new Patron
            {
                Id = 5,
                FirstName = "Michael",
                LastName = "Davis",
                Address = "222 Cedar St",
                Email = "michaeldavis@example.com",
                IsActive = false
            }
        });
        
    }

}