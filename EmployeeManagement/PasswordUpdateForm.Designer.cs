
namespace EmployeeManagement
{
    partial class frmPasswordUpdate
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
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtOldPassWord = new System.Windows.Forms.TextBox();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(87, 50);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(89, 17);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(87, 100);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(94, 17);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(122, 148);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(54, 17);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm";
            // 
            // txtOldPassWord
            // 
            this.txtOldPassWord.Location = new System.Drawing.Point(203, 47);
            this.txtOldPassWord.Name = "txtOldPassWord";
            this.txtOldPassWord.Size = new System.Drawing.Size(187, 25);
            this.txtOldPassWord.TabIndex = 1;
            this.txtOldPassWord.UseSystemPasswordChar = true;
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Location = new System.Drawing.Point(203, 92);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.Size = new System.Drawing.Size(187, 25);
            this.txtNewPassWord.TabIndex = 2;
            this.txtNewPassWord.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPassWord
            // 
            this.txtConfirmNewPassWord.Location = new System.Drawing.Point(203, 140);
            this.txtConfirmNewPassWord.Name = "txtConfirmNewPassWord";
            this.txtConfirmNewPassWord.Size = new System.Drawing.Size(187, 25);
            this.txtConfirmNewPassWord.TabIndex = 3;
            this.txtConfirmNewPassWord.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(203, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 25);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPasswordUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConfirmNewPassWord);
            this.Controls.Add(this.txtNewPassWord);
            this.Controls.Add(this.txtOldPassWord);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "frmPasswordUpdate";
            this.Text = "Password Update Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtOldPassWord;
        private System.Windows.Forms.TextBox txtNewPassWord;
        private System.Windows.Forms.TextBox txtConfirmNewPassWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
    }
}