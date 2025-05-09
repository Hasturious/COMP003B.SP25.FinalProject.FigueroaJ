using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cascade delete for Favorites (user delete)
            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Automatically delete favorites when user is deleted

            // Set foreign key to NULL for Favorites when a Recipe is deleted
            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Recipe)
                .WithMany()
                .HasForeignKey(f => f.RecipeId)
                .OnDelete(DeleteBehavior.SetNull); // Set RecipeId to NULL when the recipe is deleted

            // Cascade delete for Reviews (user delete)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Automatically delete reviews when user is deleted

            // Set foreign key to NULL for Reviews when a Recipe is deleted
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Recipe)
                .WithMany()
                .HasForeignKey(r => r.RecipeId)
                .OnDelete(DeleteBehavior.SetNull); // Set RecipeId to NULL when the recipe is deleted

            base.OnModelCreating(modelBuilder);
        }

    }
}
