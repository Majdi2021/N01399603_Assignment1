using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// this method will perform 4 math operation to an input number
        /// and output the valu
        /// </summary>
        /// <param name="id">input of number</param>
        /// <returns>output value</returns>
        /// <example>
        /// GET api/NumberMachine/10   -> 32
        /// </example>

        public decimal Get(int id)
        {
            // Performing 4 math operations
            id = id / 2;
            id = id * 3;
            id = id + 5;
            id = id - 4;

            return id;
        }
    }
}
