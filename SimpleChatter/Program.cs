using System;
using System.IO;

namespace SimpleChatter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add a line to the main method to print the text “Hello World!”
            Console.WriteLine("Hello World!");

            // Ask the user for their name and change the message to “Hello, <name>!”
            Console.Out.WriteLine("What's your name?");
            string usersName = Console.ReadLine();

            Console.WriteLine("Hello " + usersName);

            // Ask the user a yes or no question such as “Are you having a good day?”
            Console.WriteLine("Have you had a good day?");
            string goodDay = Console.ReadLine();

            // If they answer yes, display a response of your choosing
            if (goodDay.Contains("No") == true)
            {
                Console.WriteLine("Sorry to hear that...");
            }

            else if (goodDay.Contains("no") == true)
            {
                Console.WriteLine("Sorry to hear that...");
            }

            else if (goodDay.Contains("n't") == true)
            {
                Console.WriteLine("Sorry to hear that...");
            }

            else
            {
                Console.WriteLine("Good to hear!");
            }

            // If they answer no, display an alternative response of your choosing


/*

Update your program so it picks a random question from a set of at least 3, and so that it gives positive/negative answers that correspond to each question accordingly

*/

        }
    }
}
