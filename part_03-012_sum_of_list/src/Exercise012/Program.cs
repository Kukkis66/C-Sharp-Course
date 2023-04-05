namespace Exercise012
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int summa = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int numero = list[i];
                summa += numero;
            }
            Console.WriteLine("Sum: " + summa);
        }
    }
}
