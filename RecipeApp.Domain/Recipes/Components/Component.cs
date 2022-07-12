using RecipeApp.Core.Domain;
using RecipeApp.Domain.Ingredients;

namespace RecipeApp.Domain.Recipes.Components
{

    public class Component : aEntity
    {
        public List<Measurement> Mesurements { get; set; }
        public string RawText { get; set; }
        public string ExtraComment { get; set; }
        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int Position { get; set; }
    }

}