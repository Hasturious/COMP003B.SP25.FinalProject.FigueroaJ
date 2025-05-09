namespace COMP003B.SP25.FinalProject.FigueroaJ.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }    
        public string Name { get; set; }  
        public double Quantity { get; set; }
        public string Unit { get; set; }         
        public int RecipeId { get; set; }              
    }
}
