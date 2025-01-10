using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.DAO.Models
{
    public class Shipment
    {
        [Key]
        [Column("shipmentcode")]
        public Guid ShipmentCode { get; set; }

        [Column("trackingnumber")]
        public Guid TrackingNumber {  get; set; }

        [Column("ordernumber")]
        public Guid OrderNumber { get; set; }

        [Column("userid")]
        public Guid UserId { get; set; }

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("streetaddress")]
        public string StreetAddress { get; set; } = string.Empty;

        [Column("postalcode")]
        public int PostalCode { get; set; }

        [Column("country")]
        public string Country { get; set; } = string.Empty;

        [Column("city")]
        public string City { get; set; } = string.Empty;

        [Column("deliverydate")]
        public DateOnly DeliveryDate { get; set; }

        [Column("shipmentdate")]
        public DateOnly ShipmentDate { get; set; }
    }
}
