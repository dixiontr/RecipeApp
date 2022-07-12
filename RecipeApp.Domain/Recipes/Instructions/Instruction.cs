using RecipeApp.Core.Domain;

namespace RecipeApp.Domain.Recipes.Instructions
{

    public class Instruction : aEntity
    {
        public string DisplayText { get; set; }
        public int StartTime { get; set; }
        public string Appliance { get; set; }
        public int EndTime { get; set; }
        public int? Temperature { get; set; }
        public int Position { get; set; }
        public Guid RecipeId { get; set; }
    }

}