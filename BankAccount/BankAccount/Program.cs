using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean stop = false;
            double balance;

            while (true)
            {
                Console.WriteLine("Hello. Please enter your initial amount that you would like to deposit: ");
                balance = Double.Parse(Console.ReadLine());

                if (balance >= 0)
                {
                    break;
                }

            }

            Bank bankAccount = new Bank(balance);

            while (!stop)
            {
                Console.WriteLine("\nPlease choose the action you would like to perform: ");
                Console.WriteLine("1. Make a deposit");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Exit");

                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Please enter the amount you would like to deposit: ");
                    string response = bankAccount.makeDeposit(Double.Parse(Console.ReadLine()));
                    Console.WriteLine(response);

                    Console.WriteLine("\nYour balance: " + bankAccount.getBalance());
                }

                if (Console.ReadLine() == "2")
                {
                    Console.WriteLine("Please enter the amount you would like to withdraw: ");
                    string response = bankAccount.withdraw(Double.Parse(Console.ReadLine()));
                    Console.WriteLine(response);

                    Console.WriteLine("\nYour balance: " + bankAccount.getBalance());
                }

                if (Console.ReadLine() == "3")
                    stop = true;
            }
        }
    }
}
