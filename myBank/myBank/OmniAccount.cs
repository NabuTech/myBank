using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class OmniAccount : Account
    {
        public OmniAccount(double interestRate = 0.0, decimal overdraftLimit = 0.0m, decimal feeForFailedWithdrawals = 0.0m)
        {
            InterestRate = interestRate;
            OverdraftLimit = overdraftLimit;
            FeeForFailedWithdrawals = feeForFailedWithdrawals;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override bool Withdraw(decimal amount)
        {
            if (Balance + OverdraftLimit >= amount)
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
            if (Balance > 1000)
            {
                Balance += (decimal)((Balance - 1000) * (decimal)InterestRate);
            }
        }

        public override string ToString()
        {
            return $"Omni Account (ID: {UniqueID}), Balance: {Balance:C}";
        }
    }


}
