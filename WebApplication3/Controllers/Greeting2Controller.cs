using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class Greeting2Controller : ApiController
    {
        [HttpGet]
        [Route("api/Greeting2/{id}")]
        public string GET(int id)
        {
            string message = $"Greetings to {id} people!";
            return (message);
        }
    }
}
