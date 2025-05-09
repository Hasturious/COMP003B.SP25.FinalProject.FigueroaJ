using COMP003B.SP25.FinalProject.FigueroaJ.Models;

public class Review
{
    public int ReviewId { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }

    public string Content { get; set; }
    public bool Rating { get; set; } // true = good, false = bad : inspired from Steam
}
