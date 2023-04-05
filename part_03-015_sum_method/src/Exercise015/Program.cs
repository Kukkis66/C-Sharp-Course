namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static int Sum(List<int> numbers)
        {
            int summa = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int numero = numbers[i];
                summa += numero;
            }
            return summa;
        }
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            Console.WriteLine(Sum(numbers));

            numbers.Add(5);
            numbers.Add(1);
            Console.WriteLine(Sum(numbers));
        }
    }
}
