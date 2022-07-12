namespace RecipeApp.DataFetch.TastyApp.DTO
{
    public record ComponentDTO
    {
        public List<MeasurementDTO> measurements { get; set; }
        public string raw_text { get; set; }
        public string extra_comment { get; set; }
        public IngredientDTO IngredientDto { get; set; }
        public int position { get; set; }
    }

    public record IngredientDTO
    {
        public string name { get; set; }
        public string display_plural { get; set; }
        public string display_singular { get; set; }
    }

    public record InstructionDTO
    {
        public string display_text { get; set; }
        public int start_time { get; set; }
        public string appliance { get; set; }
        public int end_time { get; set; }
        public int? temperature { get; set; }
        public int position { get; set; }
    }

    public record MeasurementDTO
    {
        public UnitDTO UnitDto { get; set; }
        public string quantity { get; set; }
    }

    public record NutritionDTO 
    {
        public int? sugar { get; set; }
        public int? carbohydrates { get; set; }
        public int? fiber { get; set; }
        public int? protein { get; set; }
        public int? fat { get; set; }
        public int? calories { get; set; }
    }

    public record RecipeDTO
    {
        public string thumbnail_url { get; set; }
        public string thumbnail_alt_text { get; set; }
        public string servings_noun_singular { get; set; }
        public int? prep_time_minutes { get; set; }
        public int? cook_time_minutes { get; set; }
        public string name { get; set; }
        public List<SectionDTO> sections { get; set; }
        public int? total_time_minutes { get; set; }
        public int num_servings { get; set; }
        public string servings_noun_plural { get; set; }
        public string yields { get; set; }
        public List<InstructionDTO> instructions { get; set; }
        public NutritionDTO NutritionDto { get; set; }
        public string description { get; set; }
    }


    public record ResultDTO
    {
        public int num_servings { get; set; }
        public int? total_time_minutes { get; set; }
        public List<InstructionDTO> instructions { get; set; }
        public string servings_noun_singular { get; set; }
        public string thumbnail_url { get; set; }
        public NutritionDTO NutritionDto { get; set; }
        public string description { get; set; }
        public string thumbnail_alt_text { get; set; }
        public string servings_noun_plural { get; set; }
        public string keywords { get; set; }
        public List<SectionDTO> sections { get; set; }
        public int? cook_time_minutes { get; set; }
        public int? prep_time_minutes { get; set; }
        public string name { get; set; }
        public List<RecipeDTO> recipes { get; set; }
    }

    public record RootDTO
    {
        public int count { get; set; }
        public List<ResultDTO> results { get; set; }
    }

    public record SectionDTO
    {
        public List<ComponentDTO> components { get; set; }
        public string name { get; set; }
        public int position { get; set; }
    }
    

    public record UnitDTO
    {
        public string display_plural { get; set; }
        public string display_singular { get; set; }
        public string abbreviation { get; set; }
        public string system { get; set; }
        public string name { get; set; }
    }
}