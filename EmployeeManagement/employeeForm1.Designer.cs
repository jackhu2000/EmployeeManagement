﻿
namespace EmployeeManagement
{
    partial class employeeForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeForm1));
            this.UserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.TotalLeaves = new System.Windows.Forms.Label();
            this.UsedLeaves = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserID.Location = new System.Drawing.Point(578, 317);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(70, 25);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(427, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emloyee ID";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FullName.Location = new System.Drawing.Point(578, 360);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(59, 25);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "Name";
            this.FullName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(110, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Password Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(714, 788);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Location = new System.Drawing.Point(396, 699);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Location = new System.Drawing.Point(547, 699);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "Message";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(427, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(427, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(427, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yearly Salary ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(427, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Leave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(427, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Used Leaves";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(427, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Salary.Location = new System.Drawing.Point(578, 403);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(59, 25);
            this.Salary.TabIndex = 0;
            this.Salary.Text = "Salary";
            this.Salary.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // TotalLeaves
            // 
            this.TotalLeaves.AutoSize = true;
            this.TotalLeaves.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalLeaves.Location = new System.Drawing.Point(578, 451);
            this.TotalLeaves.Name = "TotalLeaves";
            this.TotalLeaves.Size = new System.Drawing.Size(106, 25);
            this.TotalLeaves.TabIndex = 0;
            this.TotalLeaves.Text = "Total Leaves";
            this.TotalLeaves.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // UsedLeaves
            // 
            this.UsedLeaves.AutoSize = true;
            this.UsedLeaves.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsedLeaves.Location = new System.Drawing.Point(578, 494);
            this.UsedLeaves.Name = "UsedLeaves";
            this.UsedLeaves.Size = new System.Drawing.Size(109, 25);
            this.UsedLeaves.TabIndex = 0;
            this.UsedLeaves.Text = "Used Leaves";
            this.UsedLeaves.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Address.Location = new System.Drawing.Point(578, 537);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(77, 25);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            this.Address.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Phone.Location = new System.Drawing.Point(578, 611);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(62, 25);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(427, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "City";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.City.Location = new System.Drawing.Point(578, 577);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(42, 25);
            this.City.TabIndex = 0;
            this.City.Text = "City";
            this.City.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 258);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(193, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(540, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // employeeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(914, 873);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.UsedLeaves);
            this.Controls.Add(this.TotalLeaves);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.UserID);
            this.Name = "employeeForm1";
            this.Text = "employeeForm1";
            this.Load += new System.EventHandler(this.employeeForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label TotalLeaves;
        private System.Windows.Forms.Label UsedLeaves;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}