namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);
        }
        public static void PrintArrayInStars(int[] array)
        {
            int index = 0;
            while (index < array.Length)
            {
                string number = new string('*', array[index]);
                Console.WriteLine(number);
                index += 1;

            }


        }
    }
}