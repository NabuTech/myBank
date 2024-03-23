namespace myBank
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.LightGreen;
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnManageAccount.Location = new System.Drawing.Point(330, 380);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(164, 50);
            this.btnManageAccount.TabIndex = 18;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseCompatibleTextRendering = true;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(330, 300);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(164, 50);
            this.btnDeleteCustomer.TabIndex = 17;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseCompatibleTextRendering = true;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditCustomer.Location = new System.Drawing.Point(330, 220);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(164, 50);
            this.btnEditCustomer.TabIndex = 16;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseCompatibleTextRendering = true;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // panelCustomers
            // 
            this.panelCustomers.Location = new System.Drawing.Point(573, 153);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(212, 277);
            this.panelCustomers.TabIndex = 15;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(16, 153);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(243, 277);
            this.listBoxCustomers.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(305, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 59);
            this.label2.TabIndex = 13;
            this.label2.Text = "Accounts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddCustomer.Location = new System.Drawing.Point(330, 153);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(164, 50);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseCompatibleTextRendering = true;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 71);
            this.label1.TabIndex = 19;
            this.label1.Text = "myBank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.panelCustomers);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label1;
    }
}