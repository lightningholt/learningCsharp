/*
 * Bank accounts in this tutorial are defined by these 7 things:
 * 1. It has a 10-digit number that uniquely identifies the bank account.
 * 2. It has a string that stores the name or names of the owners.
 * 3. The balance can be retrieved.
 * 4. It accepts deposits.
 * 5. It accepts withdrawals.
 * 6. The initial balance must be positive.
 * 7. Withdrawals cannot result in a negative balance
 */

using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
        // everything in here defines the class. Collectively known as members
        // members breakdown into properties, and methods
        private static int accountNumberSeed = 1234567890; // private property
        public string Number { get; } // property
        public string Owner { get; set; } // property
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        } // property

        // each class also needs a constructor which initializes the class
        // constructors have same name as class.
        public BankAccount(string name, decimal initialBalance) // constructor
        {
            this.Owner = name;
            //this.Balance = initialBalance;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note) // method
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note) // method
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}