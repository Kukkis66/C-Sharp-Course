namespace Exercise012
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      string input = Console.ReadLine();
      int intValue = Convert.ToInt32(input);
      Console.WriteLine("You gave "+intValue);
    }
  }
}
