namespace Exercise035
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
        if(answer == 42)
        {
          break;
        }
      }
    }
  }
}
