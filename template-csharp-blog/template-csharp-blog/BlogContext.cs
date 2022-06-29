using template_csharp_blog.Models;
using Microsoft.EntityFrameworkCore;



namespace template_csharp_blog
{
    public class BlogContext: DbContext
    {
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb; Database=blog; Trusted_Connection=True;";

                                                  //"Server=(localdb)\\mssqllocaldb;Database=BlogProject;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().HasData(
                new Catagory() { Id = 1, Name = "Travel"},
                new Catagory() { Id = 2, Name = "Food" },
                new Catagory() { Id = 3, Name = "Pets" },
                new Catagory() { Id = 4, Name = "Hobbies" },
                new Catagory() { Id = 5, Name = "Family" }
                );

            modelBuilder.Entity<Post>().HasData(
             new Post() { Id = 1, Catagories = new List<Catagory>(), Name = "Dina", Title = "The high pitch scream", DateTime = DateTime.Now}
             );

        }


    }
}
