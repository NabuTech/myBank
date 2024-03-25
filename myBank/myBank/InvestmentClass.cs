using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class InvestmentAccount : Account
    {
        public InvestmentAccount(double interestRate = 0.0, decimal feeForFailedWithdrawals = 10.0m)
        {
            InterestRate = interestRate;
            FeeForFailedWithdrawals = feeForFailedWithdrawals;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                // Sufficient funds, deduct the amount
                Balance -= amount;
                return true; // Withdrawal successful
            }
            else
            {
                // Insufficient funds, handle based on account type
                if (FeeForFailedWithdrawals > 0)
                {
                    // Deduct the withdrawal fee
                    Balance -= FeeForFailedWithdrawals;
                    Console.WriteLine($"Withdrawal fee deducted: {FeeForFailedWithdrawals:C}");
                }

                // Throw the exception for account type restriction
                throw new NoOverdraftAllowedException();
            }
        }


        public override void CalculateInterest()
        {
            Balance += (decimal)(Balance * (decimal)InterestRate);
        }

        public override string ToString()
        {
            return $"Investment Account (ID: {UniqueID}), Balance: {Balance:C}";
        }

    }



}
