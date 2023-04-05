namespace Exercise022
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string integerStr1 = Console.ReadLine();
      int integer1 = Convert.ToInt32(integerStr1);
      Console.WriteLine("Give the second number!");
      string integerStr2 = Console.ReadLine();
      int integer2 = Convert.ToInt32(integerStr2);
      Console.WriteLine("Give the third number!");
      string integerStr3 = Console.ReadLine();
      int integer3 = Convert.ToInt32(integerStr3);
      Console.WriteLine("The average is "+((double)integer1+integer2+integer3)/3);
    }
  }
}
