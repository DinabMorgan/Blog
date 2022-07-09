using template_csharp_blog.Models;
using Microsoft.EntityFrameworkCore;



namespace template_csharp_blog
{
    public class BlogContext: DbContext
    {
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet <Platform> Platforms { get; set; } 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb; Database=blog; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().HasData(
                new Catagory() { Id = 1, Name = "Action" },
                new Catagory() { Id = 2, Name = "Comedy" },
                new Catagory() { Id = 3, Name = "RomCom" },
                new Catagory() { Id = 4, Name = "Drama" },
                new Catagory() { Id = 5, Name = "SciFi" },
                new Catagory() { Id = 6, Name = "Fantasy"},
                new Catagory() { Id = 7, Name = "Animation"},
                new Catagory() { Id = 8, Name = "Kids"},
                new Catagory() { Id = 9, Name = "Mystical" },
                new Catagory() { Id = 10, Name = "Reality"}
                );
            modelBuilder.Entity<Platform>().HasData(
                new Platform() { Id = 1, Name = "Netflix", Cost = 15.99},
                new Platform() { Id = 2, Name = "Hulu", Cost = 10.99 },
                new Platform() { Id = 3, Name = "AppleTV", Cost = 5.99 },
                new Platform() { Id = 4, Name = "Disney+", Cost = 5.99 },
                new Platform() { Id = 5, Name = "Noggin", Cost = 2.99 },
                new Platform() { Id = 6, Name = "Prime", Cost = 8.99 },
                new Platform() { Id = 7, Name = "HBOMax", Cost = 12.99 },
                new Platform() { Id = 8, Name = "Cable", Cost = 44.99 },
                new Platform() { Id = 9, Name = "CW", Cost = 0.00 },
                new Platform() { Id = 10, Name = "Paramount+", Cost = 5.99 }
                );
            modelBuilder.Entity<Post>().HasData(
             new Post() { Id = 1, CatagoryId = 1, Author = "Dina", Title = "MoonKnight", DateTime = DateTime.Now, IsRewatchable = true, Rating = 8, Thoughts = "Gripping", PlatformId = 4 },
             new Post() { Id = 2, CatagoryId = 2, Author = "Dina", Title = "Schitt's Creek", DateTime = DateTime.Now, IsRewatchable = true, Rating = 10, Thoughts = "Well Wishes and Warmest Regards", PlatformId = 1 },
             new Post() { Id = 3, CatagoryId = 5, Author = "Dina", Title = "Star Trek", DateTime = DateTime.Now, IsRewatchable = true, Rating = 10, Thoughts = "", PlatformId = 10 },
             new Post() { Id = 4, CatagoryId = 7, Author = "Dina", Title = "She-Ra", DateTime = DateTime.Now, IsRewatchable = true, Rating = 10, Thoughts = "By the power of Greyskull", PlatformId = 1 },
             new Post() { Id = 5, CatagoryId = 4, Author = "Dina", Title = "NCIS", DateTime = DateTime.Now, IsRewatchable = false, Rating = 2, Thoughts = "Very Repeatative ", PlatformId = 8 }

             );

        }


    }
}
