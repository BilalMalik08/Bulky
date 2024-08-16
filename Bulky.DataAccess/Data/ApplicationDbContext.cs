using Bulky.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Science Fiction", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Thriller", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Romance", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Fantasy", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Adventure", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Nature", DisplayOrder = 9 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Explore the delicate dance between destiny and choice in this gripping tale of time travel and its profound effects on the lives it touches. A journey through the ages where every decision alters the future.",
                    ISBN = "SWD9999001",
                    ListPrice = 999,
                    Price = 900,
                    Price50 = 850,
                    Price100 = 800,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "A haunting narrative of survival and hope in a world overshadowed by chaos. Follow the characters as they navigate through ominous landscapes and uncover secrets that could change everything.",
                    ISBN = "CAW777777701",
                    ListPrice = 400,
                    Price = 300,
                    Price50 = 250,
                    Price100 = 200,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "A heartwarming story of love, loss, and self-discovery, set against the backdrop of breathtaking sunsets. A tale that will make you believe in the power of new beginnings.",
                    ISBN = "RITO5555501",
                    ListPrice = 550,
                    Price = 500,
                    Price50 = 400,
                    Price100 = 350,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "Dive into a sweet and whimsical world where dreams are spun into reality. This enchanting tale captures the innocence of childhood and the joy of seeing magic in everyday life.",
                    ISBN = "WS3333333301",
                    ListPrice = 700,
                    Price = 650,
                    Price50 = 600,
                    Price100 = 550,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "An inspiring story of resilience and strength, set on the rugged shores where land meets sea. This novel explores the timeless battle between the elements and the human spirit.",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 300,
                    Price = 270,
                    Price50 = 250,
                    Price100 = 200,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "Step into a world of natural beauty and hidden mysteries. This lyrical narrative weaves together tales of wonder and wisdom, all inspired by the simple, yet profound, beauty of nature.",
                    ISBN = "FOT000000001",
                    ListPrice = 250,
                    Price = 230,
                    Price50 = 220,
                    Price100 = 200,
                    CategoryId = 9,
                    ImageUrl = ""
                }
            );
        }
    }
}
