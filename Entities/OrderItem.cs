using MinimalEcommerce.API.Entities;

namespace MinimalEcommerce.Entities
{
    public class OrderItem : BaseEntity 
    {
        public String? SkuCode { get; set; }
        public decimal UnitValue { get; set; }
        public int Quantity { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; } = new();
    }
}
