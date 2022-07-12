using RecipeApp.Core.Domain;

namespace RecipeApp.Domain.Ingredients
{
    public class Ingredient : aEntity
    {
        public string Name { get; set; }
        public string DisplayPlural { get; set; }
        public string DisplaySingular { get; set; }
        
    }
}