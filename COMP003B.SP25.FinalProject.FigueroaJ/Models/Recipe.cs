using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeTitle { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeInstructions { get; set; }
        public string RecipeType { get; set; }

        public string? Notes { get; set; } // I added this for the migration requirement, will likely go unused

        public List<Ingredient> Ingredients { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();
        public List<Favorite> Favorites { get; set; } = new();
    }
}
