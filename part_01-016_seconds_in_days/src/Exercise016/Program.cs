namespace Exercise016
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many days?");
      string paivat = Console.ReadLine();
      int paivatint = Convert.ToInt32(paivat);
      Console.WriteLine(paivatint*24*3600);
    }
  }
}
