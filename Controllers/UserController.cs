using AutoMapper;
using EcommerceAPI.DAO;
using EcommerceAPI.DAO.Models;
using Microsoft.AspNetCore.Mvc;
using static NuGet.Packaging.PackagingConstants;

namespace EcommerceAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IDatabaseAgent _agent;
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserController(IDatabaseAgent agent, ILogger<UserController> logger, IMapper mapper, IConfiguration configuration)
        {
            _agent = agent;
            _logger = logger;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            try
            {
                var users = _agent.GetUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve users. Error: {ex}");
                return Unauthorized("Error: " + ex);
            }
        }
    }
}
