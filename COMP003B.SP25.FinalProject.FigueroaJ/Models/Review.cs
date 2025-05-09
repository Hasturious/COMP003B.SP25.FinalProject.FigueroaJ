using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [Required]
        public bool Recomended { get; set; } //true = like, false = dislike. While I could use a typical 1-5 rating system I prefer the boolean Like/Dislike system of review (Inspired from Steam)

        public string? Comment { get; set; }

        public User User { get; set; }

        public Recipe Recipe { get; set; }
    }
}
