namespace RecipeApp.DataFetch.TastyApp.DTO
{
    public record BrandDTO
    {
        public string image_url { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string slug { get; set; }
    }

    public record CompilationDTO
    {
        public string thumbnail_alt_text { get; set; }
        public List<object> facebook_posts { get; set; }
        public int created_at { get; set; }
        public string language { get; set; }
        public int approved_at { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string slug { get; set; }
        public string aspect_ratio { get; set; }
        public int video_id { get; set; }
        public List<ShowDTO> show { get; set; }
        public string description { get; set; }
        public string draft_status { get; set; }
        public string thumbnail_url { get; set; }
        public string video_url { get; set; }
        public string canonical_id { get; set; }
        public int? buzz_id { get; set; }
        public bool is_shoppable { get; set; }
        public string promotion { get; set; }
        public object keywords { get; set; }
        public string beauty_url { get; set; }
        public string country { get; set; }
    }

    public record ComponentDTO
    {
        public List<MeasurementDTO> measurements { get; set; }
        public string raw_text { get; set; }
        public string extra_comment { get; set; }
        public IngredientDTO IngredientDto { get; set; }
        public int id { get; set; }
        public int position { get; set; }
    }

    public record CreditDTO
    {
        public string type { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string image_url { get; set; }
        public int? id { get; set; }
    }

    public record IngredientDTO
    {
        public int updated_at { get; set; }
        public string name { get; set; }
        public int created_at { get; set; }
        public string display_plural { get; set; }
        public int id { get; set; }
        public string display_singular { get; set; }
    }

    public record InstructionDTO
    {
        public string display_text { get; set; }
        public int start_time { get; set; }
        public string appliance { get; set; }
        public int end_time { get; set; }
        public int? temperature { get; set; }
        public int id { get; set; }
        public int position { get; set; }
    }

    public record MeasurementDTO
    {
        public UnitDTO UnitDto { get; set; }
        public string quantity { get; set; }
        public int id { get; set; }
    }

    public record NutritionDTO
    {
        public int? sugar { get; set; }
        public int? carbohydrates { get; set; }
        public int? fiber { get; set; }
        public DateTime? updated_at { get; set; }
        public int? protein { get; set; }
        public int? fat { get; set; }
        public int? calories { get; set; }
    }

    public record RecipeDTO
    {
        public string thumbnail_url { get; set; }
        public string thumbnail_alt_text { get; set; }
        public int updated_at { get; set; }
        public int id { get; set; }
        public string slug { get; set; }
        public string servings_noun_singular { get; set; }
        public int? prep_time_minutes { get; set; }
        public int? brand_id { get; set; }
        public List<object> facebook_posts { get; set; }
        public BrandDTO BrandDto { get; set; }
        public string aspect_ratio { get; set; }
        public int created_at { get; set; }
        public int? cook_time_minutes { get; set; }
        public List<TopicDTO> topics { get; set; }
        public string country { get; set; }
        public List<CompilationDTO> compilations { get; set; }
        public List<CreditDTO> credits { get; set; }
        public int approved_at { get; set; }
        public bool is_one_top { get; set; }
        public TotalTimeTierDTO TotalTimeTierDto { get; set; }
        public string canonical_id { get; set; }
        public string promotion { get; set; }
        public int show_id { get; set; }
        public List<TagDTO> tags { get; set; }
        public string name { get; set; }
        public string video_url { get; set; }
        public bool is_shoppable { get; set; }
        public string nutrition_visibility { get; set; }
        public UserRatingsDTO UserRatingsDto { get; set; }
        public List<SectionDTO> sections { get; set; }
        public int? total_time_minutes { get; set; }
        public string keywords { get; set; }
        public int num_servings { get; set; }
        public int? buzz_id { get; set; }
        public string servings_noun_plural { get; set; }
        public string seo_title { get; set; }
        public string yields { get; set; }
        public string language { get; set; }
        public ShowDTO ShowDto { get; set; }
        public string inspired_by_url { get; set; }
        public List<RenditionDTO> renditions { get; set; }
        public string video_ad_content { get; set; }
        public string beauty_url { get; set; }
        public string original_video_url { get; set; }
        public int video_id { get; set; }
        public List<InstructionDTO> instructions { get; set; }
        public NutritionDTO NutritionDto { get; set; }
        public bool tips_and_ratings_enabled { get; set; }
        public string description { get; set; }
        public string draft_status { get; set; }
    }

    public record RenditionDTO
    {
        public int? maximum_bit_rate { get; set; }
        public string url { get; set; }
        public int duration { get; set; }
        public int? bit_rate { get; set; }
        public string content_type { get; set; }
        public int width { get; set; }
        public int? minimum_bit_rate { get; set; }
        public string container { get; set; }
        public string poster_url { get; set; }
        public int? file_size { get; set; }
        public string aspect { get; set; }
        public string name { get; set; }
        public int height { get; set; }
    }

    public record ResultDTO
    {
        public int num_servings { get; set; }
        public object inspired_by_url { get; set; }
        public int? total_time_minutes { get; set; }
        public List<CreditDTO> credits { get; set; }
        public bool is_shoppable { get; set; }
        public List<object> facebook_posts { get; set; }
        public UserRatingsDTO UserRatingsDto { get; set; }
        public List<TagDTO> tags { get; set; }
        public List<object> compilations { get; set; }
        public ShowDTO ShowDto { get; set; }
        public int approved_at { get; set; }
        public string video_ad_content { get; set; }
        public string original_video_url { get; set; }
        public List<InstructionDTO> instructions { get; set; }
        public string language { get; set; }
        public object brand_id { get; set; }
        public int created_at { get; set; }
        public List<RenditionDTO> renditions { get; set; }
        public object beauty_url { get; set; }
        public string nutrition_visibility { get; set; }
        public object brand { get; set; }
        public string servings_noun_singular { get; set; }
        public string yields { get; set; }
        public string promotion { get; set; }
        public int? video_id { get; set; }
        public string country { get; set; }
        public int show_id { get; set; }
        public bool is_one_top { get; set; }
        public object buzz_id { get; set; }
        public string thumbnail_url { get; set; }
        public TotalTimeTierDTO TotalTimeTierDto { get; set; }
        public int updated_at { get; set; }
        public string canonical_id { get; set; }
        public NutritionDTO NutritionDto { get; set; }
        public string description { get; set; }
        public string video_url { get; set; }
        public bool tips_and_ratings_enabled { get; set; }
        public string aspect_ratio { get; set; }
        public string thumbnail_alt_text { get; set; }
        public string servings_noun_plural { get; set; }
        public List<TopicDTO> topics { get; set; }
        public string keywords { get; set; }
        public int id { get; set; }
        public List<SectionDTO> sections { get; set; }
        public int? cook_time_minutes { get; set; }
        public string draft_status { get; set; }
        public string seo_title { get; set; }
        public string slug { get; set; }
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

    public record ShowDTO
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public record TagDTO
    {
        public string name { get; set; }
        public int id { get; set; }
        public string display_name { get; set; }
        public string type { get; set; }
    }

    public record TopicDTO
    {
        public string name { get; set; }
        public string slug { get; set; }
    }

    public record TotalTimeTierDTO
    {
        public string tier { get; set; }
        public string display_tier { get; set; }
    }

    public record UnitDTO
    {
        public string display_plural { get; set; }
        public string display_singular { get; set; }
        public string abbreviation { get; set; }
        public string system { get; set; }
        public string name { get; set; }
    }

    public record UserRatingsDTO
    {
        public double? score { get; set; }
        public int count_negative { get; set; }
        public int count_positive { get; set; }
    }
}