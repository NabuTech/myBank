namespace myBank
{
    partial class WithdrawForm
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
            this.btnConfirmWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmWithdraw
            // 
            this.btnConfirmWithdraw.Location = new System.Drawing.Point(80, 147);
            this.btnConfirmWithdraw.Name = "btnConfirmWithdraw";
            this.btnConfirmWithdraw.Size = new System.Drawing.Size(100, 23);
            this.btnConfirmWithdraw.TabIndex = 6;
            this.btnConfirmWithdraw.Text = "Confirm Withdrawl";
            this.btnConfirmWithdraw.UseVisualStyleBackColor = true;
            this.btnConfirmWithdraw.Click += new System.EventHandler(this.btnConfirmWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add amount to Withdraw";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(80, 93);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawAmount.TabIndex = 4;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 237);
            this.Controls.Add(this.btnConfirmWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Name = "WithdrawForm";
            this.Text = "WithdrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
    }
}