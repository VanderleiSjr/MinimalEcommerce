namespace MinimalEcommerce.API.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}
