﻿using RecipeApp.Core.Domain;

namespace RecipeApp.Domain.Recipes
{

    public class Nutrition : aEntity
    {
        public Guid RecipeId { get; set; }
        public int? Sugar { get; set; }
        public int? Carbohydrates { get; set; }
        public int? Fiber { get; set; }
        public int? Protein { get; set; }
        public int? Fat { get; set; }
        public int? Calories { get; set; }
    }

}