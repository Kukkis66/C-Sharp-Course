namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int isoin = 0;
            string nimi = " ";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces = input.Split(",");
                int a = Convert.ToInt32(pieces[1]);
                int b = (2023 - a);

                if (b > isoin)
                {
                    isoin = b;

                }
                if (nimi.Length < pieces[0].Length)
                {
                    nimi = pieces[0];

                }

            }
            Console.WriteLine("Longest name: " + nimi);
            Console.WriteLine("Highest age: " + isoin);
        }
    }
}