using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{

    public class Ingredient
    {
        public int IngredientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Quantity { get; set; }

        [Required]
        public int RecipeId { get; set; }

        //This is probably a bad way to do this but removing the line below breaks things and this just works so im doing it
        [ValidateNever]
        public Recipe Recipe { get; set; }
    }

    /*
    public class Ingredient
    {
        public int IngredientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Amount { get; set; } // 1/2 cups, 2 tablespoons, etc

        public string? Diet { get; set; } // Vegan, Keto, Low carb, etc

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
    */
}
