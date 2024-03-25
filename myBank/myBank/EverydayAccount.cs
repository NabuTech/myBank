using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class EverydayAccount : Account
    {
        public EverydayAccount()
        {
            // Default in Account Class
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
            return false; // No fees for failed withdrawals for EverydayAccount
        }

        public override void CalculateInterest()
        {
            // No interest calculation for EverydayAccount
        }

        public override string ToString()
        {
            return $"Everyday Account (ID: {UniqueID}), Balance: {Balance:C}";
        }

    }



}
