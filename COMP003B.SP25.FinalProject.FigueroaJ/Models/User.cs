using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //passwords should be hased but thats not something i know how to do
        public string? Bio { get; set; }

        public ICollection<Favorite> Favorites { get; set; } // User can have many Favorites
        public ICollection<Review> Reviews { get; set; } // User can have many Reviews
    }
}
