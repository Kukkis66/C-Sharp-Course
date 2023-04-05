namespace Exercise031
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string integerStr1 = Console.ReadLine();
      int integer1 = Convert.ToInt32(integerStr1);

      if (integer1 % 2 == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
        Console.WriteLine("It is odd.");
    }
  }
}
