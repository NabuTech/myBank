﻿using System;
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
    public partial class AddCustomerInputForm : Form
    {
        public string CustomerName { get { return txtCustomerName.Text; } }
        public string ContactDetails { get { return txtContactDetails.Text; } }

        public AddCustomerInputForm()
        {
            InitializeComponent();
        }



        private void AddCustomerInputForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
