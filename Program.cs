using System;
using System.Linq;

namespace deliverable_1
{
    class Program
    {
             static void Main(string[] args)
        {
            int min = 7;
            int max = 12;

            Console.WriteLine("Enter a password:");
            string userInput = Console.ReadLine();
            int passwordLength = userInput.Length;

            if (passwordLength >= min && passwordLength <= max && userInput.Contains("!") && userInput.Any(char.IsUpper)
                && userInput.Any(char.IsLower))
            {

                Console.WriteLine("Password Valid And Accepted.");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
}
