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
    public partial class EditCustomerForm : Form
    {
        public Customer Customer { get; set; }

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            // Populate the form fields with the existing customer information
            txtCustomerNameEdit.Text = Customer.Name;
            txtContactDetailsEdit.Text = Customer.ContactDetails;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the customer information with the values from the form fields
            Customer.Name = txtCustomerNameEdit.Text;
            Customer.ContactDetails = txtContactDetailsEdit.Text;

            // Close the form with DialogResult.OK to indicate successful editing
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel to indicate canceling the edit
            DialogResult = DialogResult.Cancel;
        }
    }
}
