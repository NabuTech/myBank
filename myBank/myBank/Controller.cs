using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class Controller
    {
        private List<Account> accounts;
        private List<Customer> customers;

        public Controller()
        {
            accounts = new List<Account>();
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return customers; // Assuming 'customers' is a list containing all customer objects
        }

        public Customer GetCustomer(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                return customers[index];
            }
            return null;
        }

        public void UpdateCustomer(int customerIndex, Customer updatedCustomer)
        {
            // Update the customer at the specified index
            customers[customerIndex] = updatedCustomer;
            Console.WriteLine($"Customer updated: {updatedCustomer.Name}");
        }

        public void DeleteCustomer(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                customers.RemoveAt(index);
                Console.WriteLine($"Customer at index {index} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Invalid index: {index}. No customer deleted.");
            }
        }


        public void CreateAccount(Customer customer, AccountType accountType, double interestRate = 0, decimal overdraftLimit = 0, decimal feeForFailedWithdrawals = 0)
        {
            Account account;
            switch (accountType)
            {
                case AccountType.Everyday:
                    account = new EverydayAccount();
                    break;
                case AccountType.Investment:
                    account = new InvestmentAccount(interestRate, feeForFailedWithdrawals);
                    break;
                case AccountType.Omni:
                    account = new OmniAccount(interestRate, overdraftLimit, feeForFailedWithdrawals);
                    break;
                default:
                    throw new ArgumentException("Invalid account type.");
            }

            // Associate the account with the customer
            account.Customer = customer;

            accounts.Add(account);
            Console.WriteLine($"Account created successfully for customer {customer.Name}. Account Number: {account.UniqueID}");
        }


        public void Deposit(int accountID, decimal amount)
        {
            Account account = GetAccountByID(accountID);
            if (account != null)
            {
                account.Deposit(amount);
                Console.WriteLine($"Deposited {amount:C} to account {accountID}. New balance: {account.Balance:C}");
            }
            else
            {
                Console.WriteLine($"Account with ID {accountID} not found.");
            }
        }

        public void Withdraw(int accountID, decimal amount)
        {
            Account account = GetAccountByID(accountID);
            if (account != null)
            {
                try
                {
                    account.Withdraw(amount);
                    Console.WriteLine($"Withdrawn {amount:C} from account {accountID}. New balance: {account.Balance:C}");
                }
                catch (InsufficientFundsException)
                {
                    Console.WriteLine($"Insufficient funds in account {accountID}.");
                }
                catch (NoOverdraftAllowedException ex)
                {
                    Console.WriteLine($"Withdrawal not allowed due to account type restrictions in account {accountID}. Error: {ex.Message}");
                }
                catch (OverdraftExceededException)
                {
                    Console.WriteLine($"Withdrawal not allowed due to overdraft limit exceeded in account {accountID}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred while processing withdrawal for account {accountID}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Account with ID {accountID} not found.");
            }
        }



        public void CalculateInterest(int accountID)
        {
            Account account = GetAccountByID(accountID);
            if (account != null)
            {
                account.CalculateInterest();
                Console.WriteLine($"Interest calculated for account {accountID}. New balance: {account.Balance:C}");
            }
            else
            {
                Console.WriteLine($"Account with ID {accountID} not found.");
            }
        }

        private Account GetAccountByID(int accountID)
        {
            foreach (var account in accounts)
            {
                if (account.UniqueID == accountID)
                {
                    return account;
                }
            }
            return null;
        }

        public List<Account> GetAccountsByCustomer(Customer customer)
        {
            List<Account> customerAccounts = new List<Account>();

            foreach (Account account in accounts)
            {
                if (account.Customer == customer)
                {
                    customerAccounts.Add(account);
                }
            }

            Console.WriteLine($"Number of accounts found for customer {customer.Name}: {customerAccounts.Count}");


            return customerAccounts;
        }

        public bool TransferFunds(Account sourceAccount, Account destinationAccount, decimal transferAmount)
        {
            // Check if the source account has sufficient balance for the transfer
            if (sourceAccount.Balance >= transferAmount)
            {
                // Withdraw funds from the source account
                bool withdrawalSuccess = sourceAccount.Withdraw(transferAmount);

                if (withdrawalSuccess)
                {
                    // Deposit funds into the destination account
                    destinationAccount.Deposit(transferAmount);
                    return true; // Transfer successful
                }
                else
                {
                    // If withdrawal from the source account fails, return false
                    return false; // Transfer failed
                }
            }
            else
            {
                // If the source account does not have sufficient balance, return false
                return false; // Transfer failed
            }
        }


    }



    public enum AccountType
    {
        Everyday,
        Investment,
        Omni
    }
}
