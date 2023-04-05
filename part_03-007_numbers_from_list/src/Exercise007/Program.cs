namespace Exercise007
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
            foreach (int i in list){
              Console.WriteLine(i);
            }
              break;
          }
          list.Add(input);
      }
    }
  }
}
