using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public bool Rating { get; set;  } //true = Good false = Bad : Inspired from Steams review system
    }
}
