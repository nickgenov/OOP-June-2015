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

            var companyDeposit = new Deposit(vivacom, 100000, 0.01m);
            var individualDeposit = new Deposit(petar, 1000, 0.01m);

            var companyLoan = new Loan(vivacom, 100000, 0.01m);
            var individualLoan = new Loan(petar, 1000, 0.01m);

            var companyMortgage = new Mortgage(vivacom, 10000, 0.01m);
            var individualMortgage = new Mortgage(petar, 1000, 0.01m);

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

            foreach (var account in accounts)
            {
                Console.WriteLine("Account type: {0}, balance: {1}, rate: {2}, balance + interest: {3} (after {4} month period)", account.GetType().Name, account.Balance, account.InterestRate, account.CalculateInterest(period), period);
            }
        }
    }
}