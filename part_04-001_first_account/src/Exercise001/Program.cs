namespace Exercise001
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            Account camelTili = new Account("Camel", 100.0);
            camelTili.Deposit(20.0);
            Console.WriteLine(camelTili.balance);
        }
    }
}
