using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBank
{
    public partial class ManageAccounts : Form
    {

        private Controller controller;
        private Customer exampleCustomer;
        private Customer selectedCustomer;
        public ManageAccounts()
        {
            InitializeComponent();
            controller = new Controller();

            this.Load += ManageAccounts_Load;
        }

    
        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            exampleCustomer = new Customer( "John Doe", "0123456789");
            controller.AddCustomer(exampleCustomer);

            controller.CreateAccount(exampleCustomer, AccountType.Everyday);
            controller.CreateAccount(exampleCustomer, AccountType.Investment);
            controller.CreateAccount(exampleCustomer, AccountType.Omni);

            UpdateListBoxAccounts(exampleCustomer);
            selectedCustomer = exampleCustomer;
            lblUser.Text = $"Welcome,{exampleCustomer.CustomerNumber}, {exampleCustomer.Name}";

           
        }

        private void UpdateListBoxAccounts(Customer customer)
        {
            Console.WriteLine("Updating Listbox with Accounts");
            listBoxAccounts.Items.Clear();
            foreach (Account account in controller.GetAccountsByCustomer(customer))
            {
                listBoxAccounts.Items.Add(account);
            }
        }

        public Customer SelectedCustomers
        {
            get { return selectedCustomer; }
            set { selectedCustomer = value; }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
           
            if (listBoxAccounts.SelectedItem != null)
            {
               
                Account selectedAccount = (Account)listBoxAccounts.SelectedItem;

                using (var depositForm = new DepositForm())
                {
                    if (depositForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal depositAmount = depositForm.DepositAmount;

                        controller.Deposit(selectedAccount.UniqueID, depositAmount);

                       
                        UpdateListBoxAccounts(exampleCustomer);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
                Account selectedAccount = (Account)listBoxAccounts.SelectedItem;
                if (selectedAccount != null)
                {
                    using (WithdrawForm withdrawForm = new WithdrawForm())
                    {
                        if (withdrawForm.ShowDialog() == DialogResult.OK)
                        {
                            decimal withdrawalAmount = withdrawForm.WithdrawAmount;
                            if (selectedAccount.Withdraw(withdrawalAmount))
                            {
                                MessageBox.Show($"Successfully withdrew {withdrawalAmount:C} from the account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateListBoxAccounts(exampleCustomer); 
                            }
                            else
                            {
                                MessageBox.Show("Insufficient funds for withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account to withdraw from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(selectedCustomer);
            transferForm.SelectedCustomer = exampleCustomer;
            DialogResult result = transferForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateListBoxAccounts(exampleCustomer);
            }
        }
    }
    }
