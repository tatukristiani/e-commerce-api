using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.DAO.Models
{
    public class OrderLine
    {
        [Column("ordernumber")]
        public Guid OrderNumber { get; set; }

        [Column("sku")]
        public Guid Sku {  get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("unitprice")]
        public float UnitPrice { get; set; }

        [Column("weight")]
        public float Weight { get; set; }

        [Column("totalweight")]
        public float TotalWeight { get; set; }

        [Column("totalprice")]
        public float TotalPrice { get; set; }
    }
}
