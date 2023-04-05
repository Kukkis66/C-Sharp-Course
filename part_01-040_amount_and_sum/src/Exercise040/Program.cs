namespace Exercise040
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number = 0;
      int sum = 0;
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
         sum += answer;
        }
        
      }
      Console.WriteLine("Total sum of numbers: "+sum);
      Console.WriteLine("Total amount of numbers: "+number);
      
    }
  }
}
