using MinimalEcommerce.API.Entities;
using MinimalEcommerce.Interfaces;

namespace MinimalEcommerce.Entities
{
    public class Address : BaseEntity
    {
        public String? Street { get; set; }
        public int Number { get; set; }
        public String? ZipCode { get; set; }
        public String? Neighbourhood { get; set; }
        public String? State { get; set; }
        public String? CountryCode { get; set; }
    }


}
