using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public abstract class Account
    {
        private static int nextID = 1;

        public int UniqueID { get; }
        public decimal Balance { get; protected set; }
        public double InterestRate { get; protected set; }
        public decimal OverdraftLimit { get; protected set; }
        public decimal FeeForFailedWithdrawals { get; protected set; }

        public Customer Customer { get; set; }

        public Account()
        {
            UniqueID = nextID++;
            Balance = 0;
            InterestRate = 0.0;
            OverdraftLimit = 0.0m;
            FeeForFailedWithdrawals = 0.0m;
            Customer = Customer;
        }

        public abstract void Deposit(decimal amount);
        public abstract bool Withdraw(decimal amount);
        public abstract void CalculateInterest();
    }


}
