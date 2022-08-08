using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask_8_5_22
{
    class CheckBalanceException : Exception
    {
        public CheckBalanceException(string str):base(str)
        {

        }
    }
    class BankAccount
    {
        long acc_No;
        string name;
        double balance ;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public long Acc_No
        {
            get
            {
                return acc_No;
            }
            set
            {
                acc_No = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public void ShowAcc_Details()
        {
            Console.WriteLine("Acc_no is " + acc_No);
            Console.WriteLine("Acc Holder Name is  " + name);
            Console.WriteLine("Acc Balance is " + balance);

        }

        public void DepositTransaction()
        {
            Console.WriteLine("enter the Amount you want to deposit");
            double amount = double.Parse(Console.ReadLine());
            balance = balance + amount;
            Console.WriteLine("Account Updated Successfully");
            Console.WriteLine("Total balance is "+balance);


        }
        public void WithdrawTransaction()
        {
            Console.WriteLine("enter the Amount you want to withdraw");
            double amountwd = double.Parse(Console.ReadLine());
            
            if (amountwd>balance)
            {
                Console.WriteLine("not have sufficient balance ");
            }
            else
            {
                balance = balance - amountwd;
                if (balance < 500)
                {
                    throw new CheckBalanceException("Unable to Process your request , Balance should not be less than 500");
                }
                else
                {
                    Console.WriteLine("updated balance is " + balance);
                }
            }

        }
        public void CheckBalance()
        {
            Console.WriteLine("Acc Balance is " + balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            Console.WriteLine("Enter the details of your Account");
            Console.WriteLine("Enter the Acc No");
            b.Acc_No = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name of Account Holder");
            b.Name = Console.ReadLine();
            Console.WriteLine("Enter the Balance");
            b.Balance = double.Parse(Console.ReadLine());
            
            if (b.Balance<500)
            {
                throw new CheckBalanceException("Balance should not be less than 500");
            }
            else
            {
                Console.WriteLine("details Entered successfully");
                b.ShowAcc_Details();
                Console.WriteLine("Want to perform ? \n1.Deposit\n2.Withdraw\n3.CheckBalance\n4.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        b.DepositTransaction();
                        break;
                    case 2:
                        b.WithdrawTransaction();
                        break;
                    case 3:
                        b.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("enter valid choice");
                        break;
                        
                }
            }
           

        }
    }
}
