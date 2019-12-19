using LeonCustomerTracker.ApiModels;
using LeonCustomerTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeonCustomerTracker.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {

        public BaseController()
        {

        }

        [HttpPost("[action]")]
        public void AddClient( [FromBody] ClientDetailsDto clientData, [FromServices] IClientService clientService) // ! Set Type on front and backend
        {
            // Todo Validation
            clientService.Add(clientData);
        }


        [HttpGet("[action]")]
        public string GetTest()
        {
            return "test controller";
        }
    }
}
