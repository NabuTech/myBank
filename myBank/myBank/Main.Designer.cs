namespace myBank
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "myBank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(255, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 165);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, to myBank. Please choose Accounts to manage your account or Customers to" +
    " manage customers.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.BackColor = System.Drawing.Color.LightGreen;
            this.btnManageAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccounts.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnManageAccounts.Location = new System.Drawing.Point(216, 258);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(123, 50);
            this.btnManageAccounts.TabIndex = 2;
            this.btnManageAccounts.Text = "Accounts";
            this.btnManageAccounts.UseCompatibleTextRendering = true;
            this.btnManageAccounts.UseVisualStyleBackColor = false;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.Orange;
            this.btnManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnManageCustomers.Location = new System.Drawing.Point(397, 258);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(144, 50);
            this.btnManageCustomers.TabIndex = 3;
            this.btnManageCustomers.Text = "Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "myBank App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageAccounts;
        private System.Windows.Forms.Button btnManageCustomers;
    }
}

