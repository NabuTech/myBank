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
            listBoxCustomers.Items.Clear(); 

            
            List<Customer> customers = controller.GetAllCustomers();

            
            foreach (var customer in customers)
            {
                listBoxCustomers.Items.Add($"{customer.CustomerNumber} - {customer.Name}");
            }
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomerInputForm())
            {
          
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                   
                    string name = addCustomerForm.CustomerName;
                    string contactDetails = addCustomerForm.ContactDetails;

                   
                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactDetails))
                    {
                        MessageBox.Show("Please enter valid customer name and contact details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                   
                    Customer newCustomer = new Customer(name, contactDetails);

                    controller.AddCustomer(newCustomer);

                   
                    MessageBox.Show("New customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
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
               
                using (var editCustomerForm = new EditCustomerInputForm((Customer)controller.GetCustomer(listBoxCustomers.SelectedIndex)))
                {
                    if (editCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                      
                        controller.UpdateCustomer(listBoxCustomers.SelectedIndex, editCustomerForm.EditedCustomer);
                        UpdateListBoxCustomers(); 
                    }
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
           
            if (listBoxCustomers.SelectedIndex != -1)
            {
                
                controller.DeleteCustomer(listBoxCustomers.SelectedIndex);
                UpdateListBoxCustomers(); 
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }
    }
}
