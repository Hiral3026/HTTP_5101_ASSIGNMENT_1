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
        //Get api/Square/{id}
        public IHttpActionResult Get(int id)
        {
            int result = id * id;
            return Ok(result);
        }

    }
}
