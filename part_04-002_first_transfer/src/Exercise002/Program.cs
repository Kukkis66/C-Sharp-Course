namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 1000.00);
            Account personalAccount = new Account("Personal account", 0);
            heikkisAccount.Withdrawal(100.0);
            personalAccount.Deposit(100.0);
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);
        }
    }
}