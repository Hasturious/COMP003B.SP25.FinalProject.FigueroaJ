using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }

        [Required]
        public int UserId { get; set; }         

        [ForeignKey("UserId")]
        public User User { get; set; }       

        [Required]
        public int RecipeId { get; set; }        

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }       

        public string? Note { get; set; }

        public bool Visibility { get; set; }       
    }
}
