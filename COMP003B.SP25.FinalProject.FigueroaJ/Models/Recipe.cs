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

        public ICollection<Ingredient> Ingredients { get; set; } //Recipe has many ingrediants
        public ICollection<Favorite> Favorites { get; set; } // Recipe can be favorited by many users
        public ICollection<Review> Reviews { get; set; } // Recipe can have many reviews
    }
}
