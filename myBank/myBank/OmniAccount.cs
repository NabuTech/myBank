using System;

namespace myBank
{
    public class OmniAccount : Account
    {
        

        public OmniAccount(double interestRate = 0.0, decimal overdraftLimit = 100.0m, decimal feeForFailedWithdrawals = 10.0m)
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
                throw new OverdraftExceededException();
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
