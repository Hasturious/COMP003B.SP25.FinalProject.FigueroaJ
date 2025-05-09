using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Required]
        public string RecipeTitle { get; set; }

        [Required]
        public string RecipeDescription { get; set; }

        [Required]
        public string RecipeInstructions { get; set; }

        [Required]
        public string RecipeType { get; set; } //Breakfast, lunch, dinner, possibly with diet restrictions such as vegan or keto (Might keep that in the ingredient model)

        public int UserId { get; set; }

        [ForeignKey("UserId")] // Explicitly specify foreign key relationship
        public User User { get; set; }

        public List<Favorite> Favorites { get; set; } = new();

        public List<Review> Reviews { get; set; } = new();

        public List<Ingredient> Ingredients { get; set; } = new(); // 1:M Recipe to Ingredients


        //Design Philosophy, Users create many recipies, recipies have many ingrediants. Thats 3 models
        //Could add an Review model. Users have many Reviews (as in Reviews are created by users, not that the users are reviewed), Recipies Have many Reviews
    }
}
