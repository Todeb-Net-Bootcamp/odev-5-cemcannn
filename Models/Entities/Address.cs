using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string AddressInfo { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")] //Foreign key ile Supplier id ve Supplier sınıfından türetilen Supplier nesnesini ilişkilendiriyoruz.
        public Supplier Supplier { get; set; }
    }
}
