using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
   
    public class SquareController : ApiController
    {
        [HttpGet]
        [Route("api/Square/{id}")]
        public int GET(int id)
        {
            int newid = id * id;
            return newid;
        }
    }
}
