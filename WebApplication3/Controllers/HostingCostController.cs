using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class HostingCostController : ApiController
    {
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public IEnumerable<string>GET(double id)
        {
            double costperFN = 5.50;
            double hst = 0.13;
            double fn = Math.Floor( id / 14 ) + 1;

            double newpricefn = Math.Round( fn * costperFN,2);
            double newhstfn = Math.Round(newpricefn * hst, 2);
            double totalcost = Math.Round(newpricefn + newhstfn, 2);

            string[] Answer = new string[]
            {
                String.Concat(fn , " fortnights at $5.50/FN =", newpricefn ," CAD"),
                String.Concat("HST 13% = $" ,newhstfn," CAD"),
                String.Concat("Total =$",totalcost, " CAD")

             };



            return Answer ;
            

        }
    }
}
