namespace ProgrammingIIMidterm
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCustNum = new System.Windows.Forms.TextBox();
            this.txbPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblCustNum = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCustNum
            // 
            this.txbCustNum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txbCustNum.Location = new System.Drawing.Point(55, 48);
            this.txbCustNum.Name = "txbCustNum";
            this.txbCustNum.Size = new System.Drawing.Size(162, 23);
            this.txbCustNum.TabIndex = 0;
            // 
            // txbPin
            // 
            this.txbPin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txbPin.Location = new System.Drawing.Point(55, 101);
            this.txbPin.Name = "txbPin";
            this.txbPin.Size = new System.Drawing.Size(162, 23);
            this.txbPin.TabIndex = 1;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(55, 83);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(26, 15);
            this.lblPin.TabIndex = 2;
            this.lblPin.Text = "PIN";
            // 
            // lblCustNum
            // 
            this.lblCustNum.AutoSize = true;
            this.lblCustNum.Location = new System.Drawing.Point(55, 30);
            this.lblCustNum.Name = "lblCustNum";
            this.lblCustNum.Size = new System.Drawing.Size(62, 15);
            this.lblCustNum.TabIndex = 3;
            this.lblCustNum.Text = "Account #";
            this.lblCustNum.Click += new System.EventHandler(this.lblCustNum_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(55, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(140, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(272, 200);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblCustNum);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txbPin);
            this.Controls.Add(this.txbCustNum);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbCustNum;
        private TextBox txbPin;
        private Label lblPin;
        private Label lblCustNum;
        private Button btnLogin;
        private Button btnExit;
    }
}