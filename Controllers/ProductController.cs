using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using EcommerceAPI.DAO;
using EcommerceAPI.DAO.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IDatabaseAgent _agent;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ProductController(IDatabaseAgent agent, ILogger<ProductController> logger, IMapper mapper, IConfiguration configuration)
        {
            _agent = agent;
            _logger = logger;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            try
            {
                var products = _agent.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve products. Error: {ex}");
                return Unauthorized("Error: " + ex);
            }
        }
    }
}

