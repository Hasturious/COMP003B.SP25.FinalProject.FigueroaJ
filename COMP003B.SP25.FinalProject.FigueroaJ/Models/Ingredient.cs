using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{

    public class Ingredient
    {
        public int IngredientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; } // 1/2 cups, 2 tablespoons, etc
        public string? Diet { get; set; } // Vegan, Keto, Low carb, etc

        // Foreign key to Recipe
        public int RecipeId { get; set; }
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
