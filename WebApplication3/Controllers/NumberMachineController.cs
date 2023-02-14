using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Razor.Editor;

namespace WebApplication3.Controllers
{
    public class NumberMachineController : ApiController
    {
        //Get api/NumberMachine/{id}
        public IHttpActionResult Get(int id)
        {
            int addResult = id + 10;
            int subResult = id - 10;
            int multiResult = id * 10;
            int divResult = id / 10;

            return Ok(new { AddResult = addResult, SubResult = subResult, MulResult = multiResult, DivResult = divResult });
        }
    }
}
