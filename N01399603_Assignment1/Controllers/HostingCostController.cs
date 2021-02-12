using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// this method will calculat total fortnights
        /// then will calculat 13% HST
        /// then give the total
        /// then will return detailed hosting cost
        /// </summary>
        /// <param name="id"Input of Days</param>
        /// <returns>Fortnight cost, HST, and Total</returns>
        /// <example>
        /// GET api/HostingCost/14   -> 
        /// 2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD
        /// </example>

        // GET api/HostingCost
        public IEnumerable<string> Get(int id)
        {
            // Calculating total fortnights
            // Adding 1 as time is elapsed 
            int FN = 1 + (id / 14); 
            // Calculating bill for FN
            double FNBill = FN * 5.50; // $5.50 is per FN
            // Calculating 13% HST
            double HST = FNBill * 0.13;
            // Total Bill
            double Total = HST + FNBill;
            // Concatening strings
            string s1 = FN + " fornights at $5.50/FN = $" + FNBill.ToString("0.00") + " CAD";
            string s2 = "HST 13% = $" + HST.ToString("0.00") + " CAD";
            string s3 = "Total = $" + Total.ToString("0.00") + " CAD";
            // Returning strings
            return new string[] { s1, s2, s3 };
        }
    }
}
