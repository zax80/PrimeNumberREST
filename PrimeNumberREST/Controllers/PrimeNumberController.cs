using Microsoft.AspNetCore.Mvc;
using PrimeNumberREST.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace PrimeNumberREST.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class PrimeNumberController : ControllerBase
    {
        private readonly IPrimeNumberService _service;

        public PrimeNumberController(IPrimeNumberService service)
        {
            _service = service;
        }

        [SwaggerOperation(Summary = "Check if number is prime, using parameter 'number' that is integer.")]
        [HttpGet]
        public IActionResult IsPrimeNumber(int number)
        {
            if (_service.IsPrime(number))
                return Ok($"Number {number} is prime");
            else
                return NotFound($"Number {number} is not prime");
        }

        [SwaggerOperation(Summary = "Find next prime number,  using parameter 'number' that is integer.")]
        [HttpPost]
        public IActionResult NextPrimeNumber(int number)
        {
            return Ok(_service.FindNextPrime(number));
        }
    }
}