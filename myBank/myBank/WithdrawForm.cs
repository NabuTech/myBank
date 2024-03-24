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
    public partial class WithdrawForm : Form
    {

        public decimal WithdrawAmount { get; set; }
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdrawAmount.Text, out decimal amount) && amount > 0)
            {
                WithdrawAmount = amount;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
