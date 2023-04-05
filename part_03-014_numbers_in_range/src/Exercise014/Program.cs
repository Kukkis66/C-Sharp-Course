namespace Exercise014
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
        {

            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] >= lowerLimit && numbers[i] <= upperLimit)
                {
                    Console.WriteLine(numbers[i]);

                }




            }

        }
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            numbers.Add(5);
            numbers.Add(1);
            PrintNumbersInRange(numbers, 0, 10);
        }

    }
}
