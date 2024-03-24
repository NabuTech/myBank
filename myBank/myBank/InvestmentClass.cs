using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class InvestmentAccount : Account
    {
        public InvestmentAccount(double interestRate = 0.0, decimal feeForFailedWithdrawals = 0.0m)
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
                Balance -= amount;
                return true;
            }
            else
            {
                Balance -= FeeForFailedWithdrawals;
                return false;
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
