﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class GreetingController : ApiController
    {
        [HttpPost]
        [Route("api/Greeting/mess")]
        public string mess()
        {
            return "Hello World!";
            
        }
        //[HttpGet]
        //public string Get()
        
    }
}
