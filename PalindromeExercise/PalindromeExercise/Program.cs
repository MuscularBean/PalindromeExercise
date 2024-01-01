using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            var original = input.ToLower();

            try
            {
                var num = Int32.Parse(input);
                return false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Numbers are not allowed");
            }

            if (original == "")
            {
                return false;
            }

            var reverse = new string(original.Reverse().ToArray());

            if (original == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
    
}

  

