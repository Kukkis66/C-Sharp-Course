namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int isoin = 0;
            string nimi = "";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces = input.Split(",");
                int a = Convert.ToInt32(pieces[1]);

                if (a > isoin)
                {
                    isoin = a;
                    nimi = pieces[0];
                }

            }
            Console.WriteLine("Name of the oldest: " + nimi);

        }
    }
}