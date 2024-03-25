using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace myBank
{

    public partial class AddCustomerForm : Form
    {
        public Customer Customer { get; private set; }
        
        public AddCustomerForm()
        {
            InitializeComponent();
            
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Validate input
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

           


            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
