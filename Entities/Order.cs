using MinimalEcommerce.API.Entities;
using MinimalEcommerce.Interfaces;

namespace MinimalEcommerce.Entities
{
    public class Order : BaseEntity
    {
        public decimal TotalAmmount { get; set; }
        public DateTime PlacedAt{ get; set; }
        public Decimal Discount { get; set; }
        public Decimal ShippingValue { get; set; }
        public String? CustomerName { get; set; }
        public String? CustomerDocument { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
        public List<Payment> Payments { get; set; } = new();

        public Guid BillingAddressId { get; set; }
        public Address BillingAddress { get; set; } = new();

        public Guid ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; } = new();
    }

}
