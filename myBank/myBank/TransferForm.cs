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
    public partial class TransferForm : Form
    {
        private Controller controller;
        private Customer selectedCustomer;

        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set { selectedCustomer = value; }
        }

        public TransferForm(Customer selectedCustomer)
        {
            InitializeComponent();
            controller = new Controller();
            this.selectedCustomer = selectedCustomer;
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            List<Account> accounts = controller.GetAccountsByCustomer(selectedCustomer);

            comboAccountWithdraw.Items.Clear();
            comboAccountDeposit.Items.Clear();

            foreach (Account account in accounts)
            {
                comboAccountWithdraw.Items.Add(account);
                comboAccountDeposit.Items.Add(account);
            }
            if (comboAccountWithdraw.Items.Count > 0)
                comboAccountWithdraw.SelectedIndex = 0;
            if (comboAccountDeposit.Items.Count > 0)
                comboAccountDeposit.SelectedIndex = 0;
        }

        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            Account sourceAccount = (Account)comboAccountWithdraw.SelectedItem;
            Account destinationAccount = (Account)comboAccountDeposit.SelectedItem;

            if (sourceAccount == null || destinationAccount == null)
            {
                MessageBox.Show("Please select both source and destination accounts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sourceAccount == destinationAccount)
            {
                MessageBox.Show("Source and destination accounts cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textTransferAmount.Text, out decimal transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Invalid transfer amount. Please enter a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool transferSuccessful = controller.TransferFunds(sourceAccount, destinationAccount, transferAmount);
            if (transferSuccessful)
            {
                MessageBox.Show($"Transfer of {transferAmount:C} from account {sourceAccount.UniqueID} to account {destinationAccount.UniqueID} was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Insufficient funds in the source account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
