namespace Exercise030
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
      string integerStr1 = Console.ReadLine();
      int integer1 = Convert.ToInt32(integerStr1);

      if(integer1< 0)
      {
        Console.WriteLine("Impossible");
      }
      else if(integer1<50)
      {
        Console.WriteLine("Fail");
      }
      else if(integer1<60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if(integer1<70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if(integer1<80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if(integer1<90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if(integer1<=100)
      {
        Console.WriteLine("Grade: 5");
      }
      else
      {
        Console.WriteLine("Outstanding!");
      }
    }
  }
}
