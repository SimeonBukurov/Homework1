using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = " ";
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            BankAccount newAccount = new BankAccount(username, 200);
        }
    }
}
