using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } //passwords should be hased but thats not something i know how to do

        public string? Bio { get; set; }

        public List<Review> Reviews { get; set; } = new();
        public List<Favorite> Favorites { get; set; } = new();
    }
}
