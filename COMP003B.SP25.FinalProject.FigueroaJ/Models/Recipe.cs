namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeTitle { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeInstructions { get; set; }
        public string RecipeType { get; set; } //Breakfast, lunch, dinner, possibly with diet restrictions such as vegan or keto (Might keep that in the ingredeiant model)
    }
}
