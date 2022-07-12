using RecipeApp.Core.Domain;
using RecipeApp.Domain.Recipes.Instructions;

namespace RecipeApp.Domain.Recipes
{

    public class Recipe : aEntity
    {
        public List<Section> Sections { get; set; }
        public List<Instruction> Instructions { get; set; }
        
        public Thumbnail Thumbnail { get; set; }
        
        public string Name { get; set; }
        
        public int NumServings { get; set; }
        public string ServingsNounSingular { get; set; }
        public string ServingsNounPlural { get; set; }
        
        public int? PrepTimeMinutes { get; set; }
        public int? CookTimeMinutes { get; set; }
        public int? TotalTimeMinutes { get; set; }

        public Nutrition Nutrition { get; set; }
        public string Description { get; set; }
    }

}