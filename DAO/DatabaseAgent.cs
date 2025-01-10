using EcommerceAPI.DAO.Models;

namespace EcommerceAPI.DAO
{
    public class DatabaseAgent : IDatabaseAgent
    {
        private readonly EcommerceDbContext _context;
        private readonly ILogger<DatabaseAgent> _logger;

        public DatabaseAgent(EcommerceDbContext context, ILogger<DatabaseAgent> logger)
        {
            _context = context;
            _logger = logger;
        }

        public ILogger<DatabaseAgent> Logger { get; }

        
        public IEnumerable<User> GetUsers()
        {
            return _context.users.ToList();
        }

        public IEnumerable<Role> GetRoles()
        {
            return _context.roles.ToList();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.orders.ToList();
        }

        public IEnumerable<Shipment> GetShipments()
        {
            return _context.shipments.ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.products.ToList();
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _context.orderlines.ToList();
        }
    }
}

