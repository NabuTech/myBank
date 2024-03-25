using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class WithdrawException : Exception
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }

    public class InsufficientFundsException : WithdrawException
    {
        public InsufficientFundsException() : base("Insufficient funds.")
        {
        }
    }

    public class NoOverdraftAllowedException : WithdrawException
    {
        public NoOverdraftAllowedException() : base("No overdraft allowed.")
        {
        }
    }

    public class OverdraftExceededException : WithdrawException
    {
        public OverdraftExceededException() : base("Overdraft limit exceeded.")
        {
        }
    }
}
