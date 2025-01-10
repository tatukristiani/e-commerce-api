using EcommerceAPI.DAO.Models;

namespace EcommerceAPI.DAO
{
    public interface IDatabaseAgent
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Role> GetRoles();

        IEnumerable<Order> GetOrders();
        IEnumerable<Shipment> GetShipments();

        IEnumerable<Product> GetProducts();
        IEnumerable<OrderLine> GetOrderLines();
    }
}
