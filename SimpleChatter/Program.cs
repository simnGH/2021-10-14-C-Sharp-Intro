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
            Console.WriteLine("Have you had a good day? Y or N");
            string goodDay = Console.ReadLine();


/*





Ask the user a yes or no question such as “Are you having a good day?”

If they answer yes, display a response of your choosing

If they answer no, display an alternative response of your choosing

Update your program so it picks a random question from a set of at least 3, and so that it gives positive/negative answers that correspond to each question accordingly

*/

        }
    }
}
