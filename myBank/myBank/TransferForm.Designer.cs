namespace myBank
{
    partial class TransferForm
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
            this.comboAccountWithdraw = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAccountDeposit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTransferAmount = new System.Windows.Forms.TextBox();
            this.btnConfirmTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAccountWithdraw
            // 
            this.comboAccountWithdraw.FormattingEnabled = true;
            this.comboAccountWithdraw.Location = new System.Drawing.Point(147, 147);
            this.comboAccountWithdraw.Name = "comboAccountWithdraw";
            this.comboAccountWithdraw.Size = new System.Drawing.Size(160, 21);
            this.comboAccountWithdraw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Account to withdraw from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Account to deposit too: ";
            // 
            // comboAccountDeposit
            // 
            this.comboAccountDeposit.FormattingEnabled = true;
            this.comboAccountDeposit.Location = new System.Drawing.Point(517, 147);
            this.comboAccountDeposit.Name = "comboAccountDeposit";
            this.comboAccountDeposit.Size = new System.Drawing.Size(160, 21);
            this.comboAccountDeposit.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Amount:";
            // 
            // textTransferAmount
            // 
            this.textTransferAmount.Location = new System.Drawing.Point(342, 148);
            this.textTransferAmount.Name = "textTransferAmount";
            this.textTransferAmount.Size = new System.Drawing.Size(100, 20);
            this.textTransferAmount.TabIndex = 5;
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.Location = new System.Drawing.Point(326, 236);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(126, 23);
            this.btnConfirmTransfer.TabIndex = 6;
            this.btnConfirmTransfer.Text = "Confirm Transfer";
            this.btnConfirmTransfer.UseVisualStyleBackColor = true;
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmTransfer);
            this.Controls.Add(this.textTransferAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboAccountDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAccountWithdraw);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAccountWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboAccountDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTransferAmount;
        private System.Windows.Forms.Button btnConfirmTransfer;
    }
}