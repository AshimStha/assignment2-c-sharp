using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1J2Controller : ApiController
    {
        // J1 question solution - Special Day (2015)

        /// <summary>
        ///     A function that takes two parameters; one for month and the other for the day of the month 
        ///     and returns the required output by checking if the provided date falls before or after or on Feb 18.
        /// </summary>
        /// <param name="month">The month input</param>
        /// <param name="day">The day of the month input</param>
        /// <returns>
        ///     It returns a string text i.e. "Before" or "After" or "Special" based on the comparison logic
        /// </returns>
        /// <example>
        ///     GET : /api/Assignment2/j1/SpecialDay/0/32 --> "Invalid month or date"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/j1/SpecialDay/2/17 --> "Before"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/j1/SpecialDay/2/18 --> "Special"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/j1/SpecialDay/2/19 --> "After"
        /// </example>
        /// 


        // defining the route for the request
        [Route("api/Assignment2/j1/SpecialDay/{month}/{day}")]
        // the request type
        [HttpGet]

        // function that takes the month and day parameters and returns the output
        public string SpecialDay(int month, int day)
        {
            // variable to store the output
            String output;

            // checking for invalid inputs
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                // output for invalid input
                output = "Invalid month or day.";
            }
            // checking if the provided date is before Feb 18
            else if (month < 2 || (month == 2 && day < 18))
            {
                // storing the output in the variable
                output = "Before";
            }
            // checking if the provided date is Feb 18
            else if (month == 2 && day == 18)
            {
                // output for the special date
                output = "Special";
            }
            // else statement for the dates after Feb 18
            else
            {
                // output for the date after 
                output = "After";
            }
            // returning the variable with the result text
            return output;
        }



        // J2 Question Solution - Shifty Sum (2017)

        /// <summary>
        ///     A function that takes 2 integers and adds the first integer with the values shifted
        ///     the number of times which is equal to the second integer value. Here, shifting means
        ///     adding a '0' at the end of the first integer.
        /// </summary>
        /// <param name="N">The starting number</param>
        /// <param name="K">The shifting number</param>
        /// <returns>
        ///     A shifty string sum i.e. the sum of the starting number and the nnumbers we get by shifting
        ///     a total of k times
        /// </returns>
        /// <example>
        ///     GET : /api/Assignment2/J2/ShiftySum/12/3 --> "13332"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/J2/ShiftySum/0/3 --> "Invalid N or K input value"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/J2/ShiftySum/12/5 --> "1333332"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/J2/ShiftySum/12/6 --> "Invalid N or K input value"
        /// </example>
        /// <example>
        ///     GET : /api/Assignment2/J2/ShiftySum/1234/3 --> "1370974"
        /// </example>

        // defining the route for the method
        [Route("api/Assignment2/J2/ShiftySum/{N}/{K}")]
        // defining the request type for the method
        [HttpGet]
        public string RollDice(int N, int K)
        {
            // variable to store the shifty sum
            var shiftySum = N;
            // string variable to store the final result
            string finalOutput = "";

            // if the input data fulfills the condition then
            if (N >= 1 && N <= 10000 && K >= 0 && K <= 5)
            {
                // for loop to iterate over all the possible values of k and to perform the shifts k times
                for (int i = 0; i < K; i++)
                {
                    // multiplying n by 10 shows the addition of 0 at the end
                    N *= 10;
                    // adding the shifted value with the n value
                    shiftySum += N;
                    // storing the sum into the final string variable
                    finalOutput = shiftySum.ToString();
                }
            }
            // else part for the invalid input
            else
            {
                // storing the invalid input error message in the final variable
                finalOutput = "Invalid N or K input value";
            }
            // returning the final string variable with the result
            return finalOutput;
        }
    }
}
