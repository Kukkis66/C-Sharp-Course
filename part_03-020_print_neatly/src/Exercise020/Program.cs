namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);// You can test your method here
        }

        public static void PrintNeatly(int[] array)
        {
            int index = 0;
            while (index < array.Length)
            {
                int number = array[index];
                if (index == array.Length - 1)
                {
                    Console.Write(number + "");
                }
                else
                {
                    Console.Write(number + "," + " ");
                }
                index += 1;
            }

            Console.WriteLine("");
        }
    }
}
