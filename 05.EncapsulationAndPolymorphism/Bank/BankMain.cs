using System;
using System.Collections.Generic;
using Bank.Classes;
using Bank.Interfaces;

namespace Bank
{
    public class BankMain
    {
        static void Main()
        {
            ICustomer petar = new Individual(1, "Petar Petrov");
            ICustomer vivacom = new Company(2, "Vivacom");

            var companyDeposit = new Deposit(vivacom, 100000, 10);
            var individualDeposit = new Deposit(petar, 100, 10);

            var companyLoan = new Loan(vivacom, 100000, 10);
            var individualLoan = new Loan(petar, 100, 10);

            var companyMortgage = new Mortgage(vivacom, 100000, 10);
            var individualMortgage = new Mortgage(petar, 100, 5);

            var accounts = new List<Account>()
            {
                companyDeposit,
                individualDeposit,
                companyLoan,
                individualLoan,
                companyMortgage,
                individualMortgage
            };

            int period = 6;

            //TODO debug results - not correct!

            foreach (var account in accounts)
            {
                Console.WriteLine("Account type: {0}, balance: {1}, rate: {2}, interest: {3} ({4} month period)", account.GetType().Name, account.Balance, account.InterestRate, account.CalculateInterest(period), period);
            }

        }
    }
}