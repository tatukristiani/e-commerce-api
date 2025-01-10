using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.DAO.Models
{
    public class Product
    {
        [Key]
        [Column("sku")]
        public Guid Sku { get; set; }

        [Column("productname")]
        public string ProductName {  get; set; } = string.Empty;

        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Column("unitprice")]
        public float UnitPrice { get; set; }

        [Column("weight")]
        public float Weight { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
