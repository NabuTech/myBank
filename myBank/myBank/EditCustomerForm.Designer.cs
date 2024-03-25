namespace myBank
{
    partial class EditCustomerForm
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
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.txtContactDetailsEdit = new System.Windows.Forms.TextBox();
            this.txtCustomerNameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(51, 150);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(140, 23);
            this.btnSaveCustomer.TabIndex = 11;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            // 
            // txtContactDetailsEdit
            // 
            this.txtContactDetailsEdit.Location = new System.Drawing.Point(103, 87);
            this.txtContactDetailsEdit.Name = "txtContactDetailsEdit";
            this.txtContactDetailsEdit.Size = new System.Drawing.Size(100, 20);
            this.txtContactDetailsEdit.TabIndex = 10;
            // 
            // txtCustomerNameEdit
            // 
            this.txtCustomerNameEdit.Location = new System.Drawing.Point(103, 51);
            this.txtCustomerNameEdit.Name = "txtCustomerNameEdit";
            this.txtCustomerNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerNameEdit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Customer Details";
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 238);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.txtContactDetailsEdit);
            this.Controls.Add(this.txtCustomerNameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.TextBox txtContactDetailsEdit;
        private System.Windows.Forms.TextBox txtCustomerNameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}