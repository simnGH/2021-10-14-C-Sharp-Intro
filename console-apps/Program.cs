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
        }
    }
}
