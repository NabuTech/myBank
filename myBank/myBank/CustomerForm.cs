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
    public partial class CustomerForm : Form
    {
        private Controller controller;
        public Customer Customer { get; private set; }

        public CustomerForm()
        {
            InitializeComponent();
            controller = new Controller();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            UpdateListBoxCustomers();

        }

        private void UpdateListBoxCustomers()
        {
            listBoxCustomers.Items.Clear(); // Clear existing items

            // Ensure that the controller object is not null before accessing its methods
            if (controller != null)
            {
                // Populate listBoxCustomers with customer names
                foreach (var customer in controller.GetCustomers())
                {
                    listBoxCustomers.Items.Add(customer.Name);
                }
            }
            else
            {
                // Handle the case where the controller object is null
                MessageBox.Show("Controller object is not initialized.");
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomerForm())
            {
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    // Add the new customer
                    controller.AddCustomer(addCustomerForm.Customer);
                    UpdateListBoxCustomers(); // Corrected method name
                }
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to edit.");
            }
            else
            {
                // Open a form for editing the selected customer
                using (var editCustomerForm = new EditCustomerForm())
                {
                    editCustomerForm.Customer = (Customer)controller.GetCustomer(listBoxCustomers.SelectedIndex);

                    if (editCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update the customer
                        controller.UpdateCustomer(listBoxCustomers.SelectedIndex, editCustomerForm.Customer);
                        UpdateListBoxCustomers(); // Corrected method name
                    }
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Ensure a customer is selected
            if (listBoxCustomers.SelectedIndex != -1)
            {
                // Delete the selected customer
                controller.DeleteCustomer(listBoxCustomers.SelectedIndex);
                UpdateListBoxCustomers(); // Corrected method name
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }
       

    }
}
