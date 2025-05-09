using COMP003B.SP25.FinalProject.FigueroaJ.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Data
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        
    }
}