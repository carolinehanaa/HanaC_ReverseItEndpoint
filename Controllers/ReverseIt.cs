/*Caroline Hana
10-27-2022
Reverse it - enter random numbers or letters and it will put them in reverse
Peer Review- Kenneth Fujimura -- Everything works well! The program takes in and accurately reverses whatever string is inputted into it. I couldn't really find any bugs. I really liked how you stored everything in an array that had a 'char' data type. That wasn't something I thought to do but probably should have. Great job Caroline! 10/10 A+
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_ReverseItEndpoint.Controllers
{
    [Route("[controller]")]
    public class ReverseIt : Controller
    {
        [HttpGet]
        [Route("Reverse/{input}")]
        public string Reverse(string input)
        {
            char[] reverseArray = input.ToCharArray();

            Array.Reverse(reverseArray);

            string output = new string(reverseArray);

            return output;
        }
    }
}