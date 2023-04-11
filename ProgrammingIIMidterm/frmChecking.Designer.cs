namespace ProgrammingIIMidterm
{
    partial class frmChecking
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txbTransfer = new System.Windows.Forms.TextBox();
            this.txbWithdraw = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAccount.Location = new System.Drawing.Point(83, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(13, 15);
            this.lblAccount.TabIndex = 18;
            this.lblAccount.Text = "0";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 9);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(65, 15);
            this.lblAccountNumber.TabIndex = 17;
            this.lblAccountNumber.Text = "Account #:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransfer.Location = new System.Drawing.Point(119, 84);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(116, 23);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transfer To Savings";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBalance.Location = new System.Drawing.Point(69, 40);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(34, 15);
            this.lblBalance.TabIndex = 20;
            this.lblBalance.Text = "$0.00";
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Location = new System.Drawing.Point(12, 40);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(51, 15);
            this.lblBalanceTitle.TabIndex = 19;
            this.lblBalanceTitle.Text = "Balance:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWithdraw.Location = new System.Drawing.Point(119, 130);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(116, 23);
            this.btnWithdraw.TabIndex = 21;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txbTransfer
            // 
            this.txbTransfer.Location = new System.Drawing.Point(12, 84);
            this.txbTransfer.Name = "txbTransfer";
            this.txbTransfer.Size = new System.Drawing.Size(100, 23);
            this.txbTransfer.TabIndex = 22;
            // 
            // txbWithdraw
            // 
            this.txbWithdraw.Location = new System.Drawing.Point(12, 130);
            this.txbWithdraw.Name = "txbWithdraw";
            this.txbWithdraw.Size = new System.Drawing.Size(100, 23);
            this.txbWithdraw.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnBack.Location = new System.Drawing.Point(187, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 22);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 163);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txbWithdraw);
            this.Controls.Add(this.txbTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceTitle);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.btnTransfer);
            this.Name = "frmChecking";
            this.Text = "Checking Account";
            this.Load += new System.EventHandler(this.frmChecking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAccount;
        private Label lblAccountNumber;
        private Button btnTransfer;
        private Label lblBalance;
        private Label lblBalanceTitle;
        private Button btnWithdraw;
        private TextBox txbTransfer;
        private TextBox txbWithdraw;
        private Button btnBack;
    }
}