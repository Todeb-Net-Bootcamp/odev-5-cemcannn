using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; } //Bu product'un da bir kategorisi var. Foreign key ile category id ve category sınıfından türetilen category nesnesini ilişkilendiriyoruz.
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; } //Bu product'un da bir supplier'i var. Foreign key ile supplier id ve supplier sınıfından türetilen supplier nesnesini ilişkilendiriyoruz.


    }
}
