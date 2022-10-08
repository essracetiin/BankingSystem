using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<CustomerAccount> accounts = new List<CustomerAccount>();
            CustomerAccount account1 = new CustomerAccount();
            account1.Name = "Esra";
            account1.Surname = "Çetin";
            account1.Username = "esracetin";
            account1.Password = 1234;
            account1.CustomerNo = 1;
            accounts.Add(account1);
            CustomerAccount account2 = new CustomerAccount();
            account2.Name = "Burak";
            account2.Surname = "Gülmez";
            account2.Username = "burakgulmez";
            account2.Password = 2121;
            account2.CustomerNo = 2;
            accounts.Add(account2);
            CustomerAccount account3 = new CustomerAccount();
            account3.Name = "Tugay";
            account3.Surname = "Evci";
            account3.Username = "tugayevci";
            account3.Password = 1111;
            account3.CustomerNo = 3;
            accounts.Add(account3);


            bool login = false;
            while (!login)
            {
                Console.WriteLine("Welcome to ESBANK");
                Console.WriteLine("Please enter your information to login.");

                Console.WriteLine("Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Password: ");
                int password = Convert.ToInt32(Console.ReadLine());
                //string result = accounts.Find(account1.Username, account2.Username,account3.Username );
                //foreach (var item in accounts)
                //{
                //    string item1 = item.Username;
                //    int item2 = item.Password;
                //}
                if (username == account1.Username && password == account1.Password)
                {
                    login = true;
                    Console.WriteLine($"Dear {account1.Name} {account1.Surname}, please select the action you want to take.");
                    Action();

                }
                else
                {
                    Console.WriteLine("Username or password is incorrect, please try again.");
                }

            }
            
                
        }
        
        public static void Action()
        {
            Console.WriteLine("1- View Balance");
            Console.WriteLine("2- Send Money");
            Console.WriteLine("3- Deposit Money");

            string choice = Console.ReadLine();
            Program program = new Program();
            if (choice == "1")
            {
                program.ViewBalance();
            }
            else if (choice == "2")
            {
                program.SendMoney();
            }
            else if (choice == "3")
            {
                program.DepositMoney();
            }

        }
        private int balance = 1000;
        public int DepositMoney()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            int deposit = Convert.ToInt32(Console.ReadLine());
            balance += deposit;
            Console.WriteLine("Balance: " + balance + " $");
            Action();
            return balance;
        }

        public int SendMoney()
        {
            
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
            return balance;
            
        }

        public int ViewBalance()
        {
            Console.WriteLine("Balance: " + balance + " $");
            Action();
            return balance;
        }
    }
}
