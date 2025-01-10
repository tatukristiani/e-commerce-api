using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.DAO.Models
{
    public class Order
    {
        [Key]
        [Column("ordernumber")]
        public Guid OrderNumber { get; set; }

        [Column("customer")]
        public Guid Customer {  get; set; }

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("orderdatetime")]
        public DateTime OrderDateTime { get; set; }

        [Column("price")]
        public float Price { get; set; }
    }
}
