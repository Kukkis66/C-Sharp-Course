namespace Exercise008
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      
      while(true)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == -1)
        {
          break;
        }
        list.Add(number);
      }
      Console.WriteLine("From where?");
      int from = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where to?");
      int to = Convert.ToInt32(Console.ReadLine());
          foreach ( int i in list){

            if (i >= from && i <= to){
              Console.WriteLine(i);
            }
      }
    }
  }
}
