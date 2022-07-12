using RecipeApp.Core.Domain;

namespace RecipeApp.Domain.Recipes
{

    public class Thumbnail : aEntity
    {
        public string ThumbnailUrl { get; set; }
        public string ThumbnailAltText { get; set; }
        public Guid RecipeId { get; set; }
    }

}