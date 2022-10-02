using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int login = 0;
            while (login == 0)
            {
                Console.WriteLine("Welcome to ESBANK");
                Console.WriteLine("Please enter your information to login.");

                CustomerAccount account1 = new CustomerAccount();
                account1.Name = "Esra";
                account1.Surname = "Çetin";
                account1.Username = "esracetin";
                account1.Password = 1234;
                account1.CustomerNo = 1;

                Console.WriteLine("Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Password: ");
                int password = Convert.ToInt32(Console.ReadLine());
                if (username == account1.Username && password == account1.Password)
                {
                    login = 1;
                    Console.WriteLine($"Dear {account1.Name} {account1.Surname}, please select the action you want to take.");
                    Action();

                }
                else
                {
                    Console.WriteLine("Username or password is incorrect, please try again.");
                }
            }
            
                
        }

        private static void Action()
        {
            Console.WriteLine("1- View Balance");
            Console.WriteLine("2- Send Money");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                ViewBalance();
            }
            else if (choice == "2")
            {
                SendMoney();
            }
            
        }

        private static void SendMoney()
        {
            int balance=0;
            Console.WriteLine("Amount to be sent:");
            int amount = Convert.ToInt32(Console.ReadLine());
            if(amount > balance || balance == 0)
            {
                Console.WriteLine("There is not enough balance in your account.");
            }
            else
            {
                Console.WriteLine("Your transfer transaction has been completed successfully.");
                balance -= amount;
                Console.WriteLine("Your remaining balance: " + balance + " $");
            }
            Action();
        }

        private static void ViewBalance()
        {
            int balance = 1000;
            Console.WriteLine("Balance: " + balance + " $");
            Action();
        }
    }
}
