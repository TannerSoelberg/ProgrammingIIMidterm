namespace ProgrammingIIMidterm
{
    partial class frmMain
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
            this.btnViewChecking = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnViewSavings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblChecking = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblCheckingNum = new System.Windows.Forms.Label();
            this.lblSavingsNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewChecking
            // 
            this.btnViewChecking.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewChecking.Location = new System.Drawing.Point(205, 20);
            this.btnViewChecking.Name = "btnViewChecking";
            this.btnViewChecking.Size = new System.Drawing.Size(158, 41);
            this.btnViewChecking.TabIndex = 7;
            this.btnViewChecking.Text = "View Checking Account";
            this.btnViewChecking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewChecking.UseVisualStyleBackColor = false;
            this.btnViewChecking.Click += new System.EventHandler(this.btnViewChecking_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDirections.Location = new System.Drawing.Point(21, 20);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(156, 15);
            this.lblDirections.TabIndex = 6;
            this.lblDirections.Text = "Select your transaction type.";
            // 
            // btnViewSavings
            // 
            this.btnViewSavings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewSavings.Location = new System.Drawing.Point(205, 83);
            this.btnViewSavings.Name = "btnViewSavings";
            this.btnViewSavings.Size = new System.Drawing.Size(158, 41);
            this.btnViewSavings.TabIndex = 8;
            this.btnViewSavings.Text = "View Savings Account";
            this.btnViewSavings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSavings.UseVisualStyleBackColor = false;
            this.btnViewSavings.Click += new System.EventHandler(this.btnViewSavings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Location = new System.Drawing.Point(205, 143);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 41);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblChecking
            // 
            this.lblChecking.AutoSize = true;
            this.lblChecking.Location = new System.Drawing.Point(21, 46);
            this.lblChecking.Name = "lblChecking";
            this.lblChecking.Size = new System.Drawing.Size(118, 15);
            this.lblChecking.TabIndex = 12;
            this.lblChecking.Text = "Checking Account #:";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(21, 70);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(108, 15);
            this.lblSavings.TabIndex = 13;
            this.lblSavings.Text = "Savings Account #:";
            // 
            // lblCheckingNum
            // 
            this.lblCheckingNum.AutoSize = true;
            this.lblCheckingNum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCheckingNum.Location = new System.Drawing.Point(145, 46);
            this.lblCheckingNum.Name = "lblCheckingNum";
            this.lblCheckingNum.Size = new System.Drawing.Size(13, 15);
            this.lblCheckingNum.TabIndex = 14;
            this.lblCheckingNum.Text = "0";
            // 
            // lblSavingsNum
            // 
            this.lblSavingsNum.AutoSize = true;
            this.lblSavingsNum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSavingsNum.Location = new System.Drawing.Point(135, 70);
            this.lblSavingsNum.Name = "lblSavingsNum";
            this.lblSavingsNum.Size = new System.Drawing.Size(13, 15);
            this.lblSavingsNum.TabIndex = 15;
            this.lblSavingsNum.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 202);
            this.Controls.Add(this.lblSavingsNum);
            this.Controls.Add(this.lblCheckingNum);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblChecking);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewSavings);
            this.Controls.Add(this.btnViewChecking);
            this.Controls.Add(this.lblDirections);
            this.Name = "frmMain";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnViewChecking;
        private Label lblDirections;
        private Button btnViewSavings;
        private Button btnLogout;
        private Label lblChecking;
        private Label lblSavings;
        private Label lblCheckingNum;
        private Label lblSavingsNum;
    }
}