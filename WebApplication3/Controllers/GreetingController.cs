using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class GreetingController : ApiController
    {
        //GET api/Greeting
        public string Get()
        {
            return "Hello World!";
        }

        //Get api/Greeting/{id}
        public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }
    }
}
