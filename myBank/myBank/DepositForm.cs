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
    public partial class DepositForm : Form
    {
        public decimal DepositAmount { get; private set; }

        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            // Add your event handling code here
        }

        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDepositAmount.Text, out decimal amount) && amount > 0)
            {
                DepositAmount = amount;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid deposit amount. Please enter a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   



}
