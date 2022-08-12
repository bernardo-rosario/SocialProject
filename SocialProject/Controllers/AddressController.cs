using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialProject.Domain;
using SocialProject.Domain.Contracts;
using System.Net;

namespace SocialProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Address>), (int)HttpStatusCode.OK)]
        public IActionResult GetAddresses()
        {
            return Ok(_service.GetAddresses());
        }
    }
}
