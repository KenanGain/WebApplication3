using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class NumberMachineController : ApiController
    {
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public int GET(int id)
        {
            int newid = (((( id + 10 ) - 6) * 4 ) / 2 );
            return newid;
        }

    }
}
