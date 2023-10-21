using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        // J3 question

        /// <summary>
        ///     A function that takes in a string text input from the user and returns the length of 
        ///     the longest possible palindrome in that input word.
        /// </summary>
        /// <param name="text">The input string text from the user</param>
        /// <returns>
        ///     The number of characters in the longest possible palindrome that can be formed in the
        ///     provided input string.
        /// </returns>

        // defining the route for the method
        [Route("api/Assignment2/J3/SecretPalindrome/{text}")]
        // defining the type of http request 
        [HttpGet]
        public string secretPalindrome(string text)
        {
            // storing the input into a variable
            string input = text;
            // setting the palindrome length to 0
            int longestPalindromeLength = 0;

            // iterating through every letters of the word
            for (int i = 0; i < input.Length; i++)
            {
                // iterating through every possible sub strings in the word
                for (int j = i; j < input.Length; j++)
                {
                    // calling the GetSubString method to extract the substring from the start and end position
                    string substring = GetSubstring(input, i, j);

                    // if the substring is a palindrome and the length is more than the variable
                    if (IsPalindrome(substring) && substring.Length > longestPalindromeLength)
                    {
                        // store the new substring length to the variable
                        longestPalindromeLength = substring.Length;
                    }
                }
            }
            // returning the number of letters in the longest possible palindrome
            return longestPalindromeLength.ToString();
        }


        // method to extract the substrings
        private string GetSubstring(string word, int start, int end)
        {
            // TODO: Implement this method to get a part of the word.
            return word;
        }

        // method to check if the provided word is a palindrome or not
        private bool IsPalindrome(string word)
        {
            // TODO: Implement this method to check if a word is a palindrome.
            return false;
        }
    }
}
