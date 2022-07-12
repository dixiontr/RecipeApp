using RecipeApp.Core.Domain;
using RecipeApp.Domain.Recipes.Components;

namespace RecipeApp.Domain.Recipes
{

    public class Section : aEntity
    {
        public List<Component> Components { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public Guid RecipeId { get; set; }
    }

}