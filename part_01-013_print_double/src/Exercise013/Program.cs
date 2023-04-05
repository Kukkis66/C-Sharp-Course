namespace Exercise013
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      string input = Console.ReadLine();
      double value = Convert.ToDouble(input);
      Console.WriteLine("You gave "+value);
    }
  }
}
