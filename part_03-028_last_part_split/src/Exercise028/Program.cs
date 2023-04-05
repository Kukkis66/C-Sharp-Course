namespace Exercise028
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {

                string text = Console.ReadLine();

                if (text == "")
                {
                    break;
                }
                string[] pieces = text.Split(" ");





                Console.WriteLine(pieces[pieces.Count() - 1]);



            }
        }
    }
}