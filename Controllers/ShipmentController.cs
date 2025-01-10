using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using EcommerceAPI.DAO;
using EcommerceAPI.DAO.Models;

namespace EcommerceAPI.Controllers
{
    [Route("api/shipments")]
    [ApiController]
    [Produces("application/json")]
    public class ShipmentController : ControllerBase
    {
        private readonly IDatabaseAgent _agent;
        private readonly ILogger<ShipmentController> _logger;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ShipmentController(IDatabaseAgent agent, ILogger<ShipmentController> logger, IMapper mapper, IConfiguration configuration)
        {
            _agent = agent;
            _logger = logger;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<Shipment>> GetShipments()
        {
            try
            {
                var shipments = _agent.GetShipments();
                return Ok(shipments);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve shipments. Error: {ex}");
                return Unauthorized("Error: " + ex);
            }
        }
    }
}

