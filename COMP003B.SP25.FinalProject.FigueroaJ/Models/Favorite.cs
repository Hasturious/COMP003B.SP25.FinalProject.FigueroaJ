using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RecipeId { get; set; }

        public string? Note { get; set; } //Personal notes on a recipe, the users can make an ingrediant replacement or perhaps a short list of who likes/dislikes this mean

        public bool Visibility { get; set; } //Shows/Hides the recipe on the users profile

        [Required]
        public User User { get; set; }

        [Required]
        public Recipe Recipe { get; set; }
    }
}
