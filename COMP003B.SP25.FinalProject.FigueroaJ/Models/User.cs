using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class User
    {
        public int UserId { get; set; }                     

        [Required]
        public string Username { get; set; }       

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; } //Yes passwords should theoretically be hashed or whatever but thats not my job

        public string Bio { get; set; }

        public Favorite Favorite { get; set; }

        public List<Recipe> Recipes { get; set; } //Each user has many recipes
    }
}
