namespace Exercise036
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
        Console.WriteLine("Give a number:");
        string answerStr = Console.ReadLine();
        int answer = Convert.ToInt32(answerStr);
        if(answer == 0)
        {
          break;
        }
        else if(answer > 0)
        {
          Console.WriteLine(answer*answer);
        }
        else if(answer < 0)
        {
          Console.WriteLine("That is negative");
        }
      }
    }
  }
}
