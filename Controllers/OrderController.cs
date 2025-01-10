using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using EcommerceAPI.DAO;
using EcommerceAPI.DAO.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/orders")]
    [ApiController]
    [Produces("application/json")]
    public class OrderController : ControllerBase
    {
        private readonly IDatabaseAgent _agent;
        private readonly ILogger<OrderController> _logger;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public OrderController(IDatabaseAgent agent, ILogger<OrderController> logger, IMapper mapper, IConfiguration configuration)
        {
            _agent = agent;
            _logger = logger;
            _mapper = mapper;
            _configuration = configuration;
        }

        /***** ORDER ENDPOINTS *****/

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            try
            {
                var orders = _agent.GetOrders();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve orders. Error: {ex}");
                return Unauthorized("Error: " + ex);
            }
        }

        /***** ORDERLINE ENDPOINTS *****/
        [HttpGet]
        [Route("orderlines")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<OrderLine>> GetOrderLines()
        {
            try
            {
                var orderLines = _agent.GetOrderLines();
                return Ok(orderLines);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve orderlines. Error: {ex}");
                return Unauthorized("Error: " + ex);
            }
        }
    }
}

