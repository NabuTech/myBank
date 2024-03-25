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
    public partial class EditCustomerInputForm : Form
    {
        public Customer EditedCustomer { get; private set; }
        public EditCustomerInputForm(Customer customerToEdit)
        {
            InitializeComponent();
     

        
            txtCustomerName.Text = customerToEdit.Name;
            txtContactDetails.Text = customerToEdit.ContactDetails;
            EditedCustomer = customerToEdit;
        }

        private void EditCustomerInputForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContactDetails.Text))
            {
                MessageBox.Show("Please enter contact details.");
                return;
            }

            
            EditedCustomer.Name = txtCustomerName.Text;
            EditedCustomer.ContactDetails = txtContactDetails.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
