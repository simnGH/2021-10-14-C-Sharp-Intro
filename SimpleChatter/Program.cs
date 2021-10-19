using System;
using System.IO;

namespace SimpleChatter
{
    class Program
    {
        public static void Question1()
        {
            // Add a line to the main method to print the text “Hello World!”
            Console.WriteLine("Hello World!");

            // Ask the user for their name and change the message to “Hello, <name>!”
            Console.Out.WriteLine("What's your name?");
            string usersName = Console.ReadLine();

            Console.WriteLine($"Hello {usersName}");

            // Ask the user a yes or no question such as “Are you having a good day?”
            Console.WriteLine("Have you had a good day?");
            string goodDay = Console.ReadLine();

            // If they answer yes, display a response of your choosing
            // If they answer no, display an alternative response of your choosing
            if (goodDay.Contains("No") == true || goodDay.Contains("no") == true || goodDay.Contains("n't") == true)
            {
                Console.WriteLine("Sorry to hear that...");
            }

            else
            {
                Console.WriteLine("Good to hear!");
            }

        }

        public static void Question2()
        {
            // Add a line to the main method to print the text “Hello World!”
            Console.WriteLine("Hello Dude!");

            // Ask the user for their name and change the message to “Hello, <name>!”
            Console.Out.WriteLine("What's your favourite colour?");
            string faveColour = Console.ReadLine();

            Console.WriteLine($"{faveColour} is my favourite too!");

            // Ask the user a yes or no question such as “Are you having a good day?”
            Console.WriteLine("Do you smell gas?");
            string goodDay = Console.ReadLine();

            // If they answer yes, display a response of your choosing
            // If they answer no, display an alternative response of your choosing
            if (goodDay.Contains("No") == true || goodDay.Contains("no") == true || goodDay.Contains("n't") == true)
            {
                Console.WriteLine("Might be my new aftershave...");
            }

            else
            {
                Console.WriteLine("Let's split...");
            }
        }

        public static void Question3()
        {
            // Add a line to the main method to print the text “Hello World!”
            Console.WriteLine("Hello Mate!");

            // Ask the user for their name and change the message to “Hello, <name>!”
            Console.Out.WriteLine("What are you drinking?");
            string faveColour = Console.ReadLine();

            Console.WriteLine($"A {faveColour}, and a scotch on the rocks for me.");

            // Ask the user a yes or no question such as “Are you having a good day?”
            Console.WriteLine("Are you driving?");
            string goodDay = Console.ReadLine();

            // If they answer yes, display a response of your choosing
            // If they answer no, display an alternative response of your choosing
            if (goodDay.Contains("No") == true || goodDay.Contains("no") == true || goodDay.Contains("n't") == true)
            {
                Console.WriteLine("Parrrrttaaaay!");
            }

            else
            {
                Console.WriteLine("You can drive us home, then. Barman, another scotch!");
            }
        }



        static void Main(string[] args)
        {

            Random rnd = new Random();
            int rndNumber = rnd.Next (1, 4);
        
            switch (rndNumber)
            { 
                case 1:
                    Question1();
                    break;
                case 2:
                    Question2();
                    break;
                default:
                    Question3();
                    break;
            }

        }
    }
}
