using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment1.Controllers
{
    /// <summary>
    /// this method will use POST to return geeting 
    /// </summary>
    /// <example>
    /// curl -d "" "http://localhost:54253/api/greeting"  -> "Hello World!"
    /// </example>
    public class GreetingController : ApiController
    {
        // POST api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// this method will get the number of people then  
        /// concatening string with that number
        /// and return greeting to that number
        /// </summary>
        /// <param name="id">input of number</param>
        /// <returns>greeting to given number</returns>
        /// <example>
        /// GET api/Greeting/3   -> Greetings to 3 people!
        /// </example>

        public string Get(int id)
        {
           return "Greetings to " + id + " people!";
        }
    }
}
