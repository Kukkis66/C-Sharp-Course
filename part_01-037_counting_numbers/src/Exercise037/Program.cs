namespace Exercise037
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number = 0;
      while(true)
      {
        Console.WriteLine("Give a number:");
        string answerStr = Console.ReadLine();
        int answer = Convert.ToInt32(answerStr);
        if(answer == 0)
        {
          break;
        }
        else
        {
         number += 1;
        }
        
      }
      Console.WriteLine("Total amount of numbers: "+number);
    }
  }
}
