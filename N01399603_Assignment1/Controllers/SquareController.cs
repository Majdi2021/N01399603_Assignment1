using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment1.Controllers
{
    // objective: create method to return the square of given number

    /// <summary>
    /// this method will multiple an input number with itself and will output
    /// the square value
    /// </summary>
    /// <param name="id">input of number</param>
    /// <returns>square value</returns>
    /// <example>
    /// GET api/Square/2   -> 4
    /// GET api/Square/-2  -> 4
    /// </example>
    public class SquareController : ApiController
    {
        // GET api/Square/5
        public int Get(int id)
        {
            return id * id;
        }
    }
}
