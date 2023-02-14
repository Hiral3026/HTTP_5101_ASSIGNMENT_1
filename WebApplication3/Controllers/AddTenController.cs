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
        // Get api/AddTen/{id}
        public IHttpActionResult Get(int id)
        {
            int result = id + 10;
            return Ok(result);
        }

    }
}
