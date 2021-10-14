using System;
using System.IO;

namespace console_apps
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reads a text file and prints the contents to the terminal
            string[] lines = File.ReadAllLines("cities.txt");

            foreach (string line in lines)
            {
                Console.Out.WriteLine(line);
            }

            //Take some input from the user and ask question
            Console.Out.WriteLine("Name a different city.");
            string userInput = Console.ReadLine();

            // Overwrites the text file with the answer
            File.WriteAllText("cities.txt",userInput);
        }
    }
}
