using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSDemo.Models;
using ServiceB.Infra;
using System.Threading.Tasks;

namespace ServiceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;
        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public async Task<Car> Get()
        {
            return await _dataService.GetData();
        }
    }
}
