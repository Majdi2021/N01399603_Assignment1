using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment1.Controllers
{
    // objective: create method to return the given number plus 10

    /// <summary>
    /// this method will add 10 to an input number and will output
    /// the total value
    /// </summary>
    /// <param name="id">input of number</param>
    /// <returns>total value</returns>
    /// <example>
    /// GET api/AddTen/21  -> 31
    /// </example>
    public class AddTenController : ApiController
    {
        // GET api/AddTen/5
        public int Get(int id)
        {
            return id + 10;
        }

    }
}
