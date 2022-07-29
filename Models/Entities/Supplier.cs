using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Product> Products { get; set; } //One to many ilişik var. Yani bir Supplier'ın birden fazla Product'ü var demek.
        public Address Address { get; set; }
    }
}