using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    /**
     * ENCAPSULATION 
     * In this BankAccount Class, it encapsulates the Deposit,withdrawal and GetBalance methods. The user will call Deposit without minding th logic in it
     */
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }
        public decimal GetBalance()
        {
            return balance;
        }


        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount MUST be a valid amount...");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 100)
            {
                throw new ArgumentException("The minimum withdrawal amount is Kes.100.");
            }
            if (balance < 100)
            {
                throw new ArgumentException("Insufficient funds");
            }
            balance -= amount;
        }
    }
}
