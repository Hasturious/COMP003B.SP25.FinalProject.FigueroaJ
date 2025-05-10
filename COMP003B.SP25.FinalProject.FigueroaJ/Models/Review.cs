namespace COMP003B.SP25.FinalProject.FigueroaJ.Models

{
    public class Review
    {
        public int ReviewId { get; set; }

        // Make UserId nullable to indicate it's optional during form binding
        public int? UserId { get; set; }

        // Make navigation property nullable to avoid validation issues
        public User? User { get; set; }

        // Same for RecipeId and Recipe
        public int? RecipeId { get; set; }

        public Recipe? Recipe { get; set; }

        public string Comment { get; set; } 
        public bool Reccomend { get; set; } //false = dislike true = like
    }
}