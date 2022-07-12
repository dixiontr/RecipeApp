namespace RecipeApp.Core.Domain
{

    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }

}