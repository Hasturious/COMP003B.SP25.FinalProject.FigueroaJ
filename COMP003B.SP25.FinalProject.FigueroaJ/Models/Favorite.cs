using COMP003B.SP25.FinalProject.FigueroaJ.Models;

public class Favorite
{
    public int FavoriteId { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int? RecipeId { get; set; }
    public Recipe Recipe { get; set; }

    public string? Note { get; set; }
    public bool Visibility { get; set; }
}
