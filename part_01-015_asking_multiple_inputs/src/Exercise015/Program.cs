namespace Exercise015
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string str = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string integerStr = Console.ReadLine();
      int intege = Convert.ToInt32(integerStr);
      Console.WriteLine("Give a double:");
      string doubleStr = Console.ReadLine();
      double doubles = Convert.ToDouble(doubleStr);
      Console.WriteLine("Give a boolean:");
      string booleanStr = Console.ReadLine();
      bool booli = Convert.ToBoolean(booleanStr);
      Console.WriteLine("Your string: "+str);
      Console.WriteLine("Your integer: "+intege);
      Console.WriteLine("Your double: "+doubles);
      Console.WriteLine("Your boolean: "+booli);
      

    }
  }
}
