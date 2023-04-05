namespace Exercise027
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number:");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            if (number > 0)
            {
                Console.WriteLine("It is positive");
            }
            else
            {
              Console.WriteLine("It is not positive");
            }
    }
  }
}




