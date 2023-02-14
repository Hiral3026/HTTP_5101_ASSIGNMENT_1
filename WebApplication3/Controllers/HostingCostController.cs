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
        //Get api/HostingCost/{id}
        public IHttpActionResult Get(int id)
        {
             
                int fortnights = (id + 13) / 14; // Add 13 to round up instead of down
                double costPerFortnight = 5.50;
                double subtotal = fortnights * costPerFortnight;
                double taxRate = 0.13;
                double tax = subtotal * taxRate;
                double total = subtotal + tax;

                string[] result = new string[]
                {
                $"{fortnights} fortnights at ${costPerFortnight:F2}/FN = ${subtotal:F2} CAD",
                $"HST {taxRate:P0} = ${tax:F2} CAD",
                $"Total = ${total:F2} CAD"
                };

                return Ok(result);
            }
    }
}
