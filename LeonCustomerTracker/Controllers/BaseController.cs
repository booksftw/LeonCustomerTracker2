using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LeonCustomerTracker.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        // NZ...
        // Constructor automatically created if ommited. 
        // You can inject your database into the constructor and save it to the props or you can inject it into each controller as singleton.

        [HttpPost("[action]")]
        public void AddClient( dynamic clientData) // ! Set Type on front and backend
        {
            // fillter 

            // the work
            Console.WriteLine(clientData);
            // add to db

            // return if any
        }

    }
}
