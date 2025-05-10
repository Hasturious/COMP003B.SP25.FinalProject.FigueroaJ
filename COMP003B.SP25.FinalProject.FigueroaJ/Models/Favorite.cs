using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models

{
    public class Favorite
    {
        public int FavoriteId { get; set; }

        // Make UserId nullable to indicate it's optional during form binding
        public int? UserId { get; set; }

        // Make navigation property nullable to avoid validation issues
        public User? User { get; set; }

        // Same for RecipeId and Recipe
        public int? RecipeId { get; set; }

        public Recipe? Recipe { get; set; }

        public string? Note { get; set; }

        public bool Visibility { get; set; }
    }
}