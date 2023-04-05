namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);
            }
            Console.WriteLine("Search for?");
            string nimi = Console.ReadLine();

            if (list.Contains(nimi) == true)
            {
                Console.WriteLine(nimi + " was found!");
            }
            else
            {
                Console.WriteLine(nimi + " was not found!");
            }

        }
    }
}

