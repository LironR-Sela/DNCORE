using Microsoft.AspNetCore.Mvc;
using MSDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: api/<CarController>
        [HttpGet]
        public Car Get()
        {
            return new Car { 
             Id = 17, Brand = "BMW", Price = 700000
            };
        }
    }
}
