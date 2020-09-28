using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BankAccount
    {
		List<double> DepositList = new List<double>();
		public string username { get; set; }

		public double Balance { get; set; }

		public BankAccount(string username, double Balance)
		{
			this.username = username;
			this.Balance = Balance;

			Console.WriteLine("Username: {0} , Balance: {1}", username, Balance);
			NextMenu();
		}

		public void NextMenu()
		{
			double balance = Balance;
			Console.WriteLine("Enter 1 for Withdrawl, 2 for Deposit, 3 for Logout");
			string StringMenu = Console.ReadLine();
			int NextChoice = Convert.ToInt32(StringMenu);
			switch (NextChoice)
			{
				case 1:
					Withdraw();
					break;
				case 2:
					Deposit();
					break;
				case 3:
					Logout();
					break;
			}
		}

		public double Withdraw()
		{
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to withdraw?: ");
			double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
			Balance = Balance -= WithdrawAmount;
			Console.WriteLine(Balance);
			NextMenu();
			return WithdrawAmount;
		}

		public double Deposit()
		{
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to deposit?: ");
			double DepositAmount = Convert.ToDouble(Console.ReadLine());


			DepositList.Add(DepositAmount);

			Balance = Balance + DepositAmount;
			Console.WriteLine(Balance);
			NextMenu();
			return DepositAmount;
		}

		public void Logout()
		{
			Console.WriteLine("Goodbye: " + username);
		}

	}
}

