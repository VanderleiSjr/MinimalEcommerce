using MinimalEcommerce.API.Entities;
using MinimalEcommerce.Interfaces;

namespace MinimalEcommerce.Entities
{
    public class Payment : BaseEntity
    {
        public int Method { get; set; }
        public decimal Value { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; } = new();
    }
}
