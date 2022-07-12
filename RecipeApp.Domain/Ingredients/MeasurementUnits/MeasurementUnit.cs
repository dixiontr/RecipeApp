using RecipeApp.Core.Domain;

namespace RecipeApp.Domain.Ingredients.MeasurementUnits
{

    public class MeasurementUnit : aEntity
    {
        public string Name { get; set; }
        public MeasurementSystem System { get; set; }
        public string Abbrevation { get; set; }
        public string DisplayPlural { get; set; }
        public string DisplaySingular { get; set; }
        
        
    }

}