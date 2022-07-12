using RecipeApp.Core.Domain;
using RecipeApp.Domain.Ingredients.MeasurementUnits;

namespace RecipeApp.Domain.Recipes.Components
{

    public class Measurement : aEntity
    {
        public MeasurementUnit Unit { get; set; }
        public string Quantity { get; set; }
        public Guid ComponentId { get; set; }
        
    }

}