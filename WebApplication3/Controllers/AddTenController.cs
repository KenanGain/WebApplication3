using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class AddTenController : ApiController
    {
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int GET(int id)
        {
            int newid = id + 10;
            return newid;
        }

    }
}
