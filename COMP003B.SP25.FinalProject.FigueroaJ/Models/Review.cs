namespace COMP003B.SP25.FinalProject.FigueroaJ.Models

{
    public class Review
    {
        public int ReviewId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public string Comment { get; set; } //false = dislike true = like
    }
}