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

            // Retrieve all customers from the controller
            List<Customer> customers = controller.GetAllCustomers();

            // Add each customer's number and name to the list box
            foreach (var customer in customers)
            {
                listBoxCustomers.Items.Add($"{customer.CustomerNumber} - {customer.Name}");
            }
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomerInputForm())
            {
                // Show the custom input form as a dialog
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the input values from the form
                    string name = addCustomerForm.CustomerName;
                    string contactDetails = addCustomerForm.ContactDetails;

                    // Validate input
                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactDetails))
                    {
                        MessageBox.Show("Please enter valid customer name and contact details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create a new customer
                    Customer newCustomer = new Customer(name, contactDetails);

                    // Add the new customer using the controller
                    controller.AddCustomer(newCustomer);

                    // Display a success message
                    MessageBox.Show("New customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the list of customers
                    UpdateListBoxCustomers();
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
                using (var editCustomerForm = new EditCustomerInputForm((Customer)controller.GetCustomer(listBoxCustomers.SelectedIndex)))
                {
                    if (editCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update the customer
                        controller.UpdateCustomer(listBoxCustomers.SelectedIndex, editCustomerForm.EditedCustomer);
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
                UpdateListBoxCustomers(); // Refresh the list of customers
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }
    }
}
