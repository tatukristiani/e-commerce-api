using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.DAO.Models
{
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("firstname")]
        public string Firstname { get; set; } = string.Empty;

        [Column("lastname")]
        public string Lastname { get; set; } = string.Empty;

        [Column("password")]
        public string Password { get; set; } = string.Empty;

        [Column("streetaddress")]
        public string Streetaddress { get; set; } = string.Empty;

        [Column("postalcode")]
        public int Postalcode { get; set; } = 0;

        [Column("country")]
        public string Country { get; set; } = string.Empty;

        [Column("city")]
        public string City { get; set; } = string.Empty;

        [Column("role")]
        public Guid Role { get; set; }

        [Column("createdat")]
        public DateTime CreatedAt { get; set; }
    }
}
