using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }

        public string? Note { get; set; } //Personal notes on a recipe, the users can make an ingrediant replacement or perhaps a short list of who likes/dislikes this mean

        public bool Visibility { get; set; } //Shows/Hides the recipe on the users profile

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int? RecipeId { get; set; } //optional for when it gets deleted
        public Recipe Recipe { get; set; }
    }
}
