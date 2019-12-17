using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeonCustomerTracker.ApiModels;
using LeonCustomerTracker.Database;
using LeonCustomerTracker.Entities;
using LeonCustomerTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeonCustomerTracker.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {

        public BaseController()
        {}

        [HttpPost("[action]")]
        public void AddClient( [FromBody] ClientDetailsDto clientData, [FromServices] IClientService clientService) // ! Set Type on front and backend
        {
            // Todo Validation
            clientService.Add(clientData);
        }



    }
}
