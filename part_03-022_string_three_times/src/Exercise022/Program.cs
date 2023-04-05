namespace Exercise022
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Give a word: ");
            string str = Console.ReadLine();
            for (int i = 0; i < 3; ++i)
            {
                Console.Write(str);

            }
            Console.WriteLine("");
        }
    }
}
