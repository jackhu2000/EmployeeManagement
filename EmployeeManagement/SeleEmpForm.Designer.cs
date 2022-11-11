namespace EmployeeManagement
{
    partial class SeleEmpForm
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
            this.Title = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addr1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addr2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalleaves = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.usedleaves = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dm = new System.Windows.Forms.TextBox();
            this.dy = new System.Windows.Forms.TextBox();
            this.ey = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.em = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ed = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.msg = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Monospac821 BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.Info;
            this.Title.Location = new System.Drawing.Point(249, 52);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(549, 39);
            this.Title.TabIndex = 2;
            this.Title.Text = "=== Employee Information ===";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(119, 159);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(284, 389);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(476, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(601, 213);
            this.firstname.MaxLength = 20;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(236, 30);
            this.firstname.TabIndex = 5;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(601, 277);
            this.lastname.MaxLength = 20;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(236, 30);
            this.lastname.TabIndex = 7;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(476, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "LastName";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(601, 342);
            this.salary.MaxLength = 8;
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(236, 30);
            this.salary.TabIndex = 9;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(476, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salary";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(601, 409);
            this.phone.MaxLength = 15;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(236, 30);
            this.phone.TabIndex = 11;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(476, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(601, 476);
            this.city.MaxLength = 20;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(236, 30);
            this.city.TabIndex = 13;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(476, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "City";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(167, 600);
            this.img.MaxLength = 60;
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(236, 30);
            this.img.TabIndex = 15;
            this.img.TextChanged += new System.EventHandler(this.img_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(87, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "ImgUri";
            // 
            // addr1
            // 
            this.addr1.Location = new System.Drawing.Point(539, 597);
            this.addr1.MaxLength = 100;
            this.addr1.Name = "addr1";
            this.addr1.Size = new System.Drawing.Size(361, 30);
            this.addr1.TabIndex = 17;
            this.addr1.TextChanged += new System.EventHandler(this.addr1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(431, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "AddrLine1";
            // 
            // addr2
            // 
            this.addr2.Location = new System.Drawing.Point(539, 666);
            this.addr2.MaxLength = 100;
            this.addr2.Name = "addr2";
            this.addr2.Size = new System.Drawing.Size(361, 30);
            this.addr2.TabIndex = 19;
            this.addr2.TextChanged += new System.EventHandler(this.addr2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(431, 669);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "AddrLine2";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(167, 666);
            this.grade.MaxLength = 3;
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(236, 30);
            this.grade.TabIndex = 21;
            this.grade.TextChanged += new System.EventHandler(this.grade_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(87, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Grade";
            // 
            // totalleaves
            // 
            this.totalleaves.Location = new System.Drawing.Point(167, 733);
            this.totalleaves.MaxLength = 3;
            this.totalleaves.Name = "totalleaves";
            this.totalleaves.Size = new System.Drawing.Size(236, 30);
            this.totalleaves.TabIndex = 23;
            this.totalleaves.TextChanged += new System.EventHandler(this.totalleaves_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(52, 736);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "TotalLeaves";
            // 
            // usedleaves
            // 
            this.usedleaves.Location = new System.Drawing.Point(167, 800);
            this.usedleaves.MaxLength = 3;
            this.usedleaves.Name = "usedleaves";
            this.usedleaves.Size = new System.Drawing.Size(236, 30);
            this.usedleaves.TabIndex = 25;
            this.usedleaves.TextChanged += new System.EventHandler(this.usedleaves_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(52, 803);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "UsedLeaves";
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(167, 871);
            this.department.MaxLength = 30;
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(236, 30);
            this.department.TabIndex = 27;
            this.department.TextChanged += new System.EventHandler(this.department_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(52, 874);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Department";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(167, 937);
            this.email.MaxLength = 30;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(236, 30);
            this.email.TabIndex = 29;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(87, 940);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 24);
            this.label13.TabIndex = 28;
            this.label13.Text = "email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(672, 739);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "DoB";
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(583, 797);
            this.dd.MaxLength = 2;
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(60, 30);
            this.dd.TabIndex = 31;
            this.dd.TextChanged += new System.EventHandler(this.dd_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(649, 800);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 24);
            this.label15.TabIndex = 32;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(734, 800);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 24);
            this.label16.TabIndex = 34;
            this.label16.Text = "/";
            // 
            // dm
            // 
            this.dm.Location = new System.Drawing.Point(668, 797);
            this.dm.MaxLength = 2;
            this.dm.Name = "dm";
            this.dm.Size = new System.Drawing.Size(60, 30);
            this.dm.TabIndex = 33;
            this.dm.TextChanged += new System.EventHandler(this.dm_TextChanged);
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(756, 797);
            this.dy.MaxLength = 4;
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(81, 30);
            this.dy.TabIndex = 35;
            this.dy.TextChanged += new System.EventHandler(this.dy_TextChanged);
            // 
            // ey
            // 
            this.ey.Location = new System.Drawing.Point(760, 932);
            this.ey.MaxLength = 4;
            this.ey.Name = "ey";
            this.ey.Size = new System.Drawing.Size(77, 30);
            this.ey.TabIndex = 41;
            this.ey.TextChanged += new System.EventHandler(this.ey_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(738, 935);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 24);
            this.label17.TabIndex = 40;
            this.label17.Text = "/";
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(672, 932);
            this.em.MaxLength = 2;
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(60, 30);
            this.em.TabIndex = 39;
            this.em.TextChanged += new System.EventHandler(this.em_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(653, 935);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 24);
            this.label18.TabIndex = 38;
            this.label18.Text = "/";
            // 
            // ed
            // 
            this.ed.Location = new System.Drawing.Point(587, 932);
            this.ed.MaxLength = 2;
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(60, 30);
            this.ed.TabIndex = 37;
            this.ed.TextChanged += new System.EventHandler(this.ed_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(601, 877);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(202, 24);
            this.label19.TabIndex = 36;
            this.label19.Text = "EmploymentStartDate";
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.isAdmin.Location = new System.Drawing.Point(621, 145);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(107, 28);
            this.isAdmin.TabIndex = 42;
            this.isAdmin.Text = "isAdmin";
            this.isAdmin.UseVisualStyleBackColor = true;
            this.isAdmin.CheckedChanged += new System.EventHandler(this.isAdmin_CheckedChanged);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.ForeColor = System.Drawing.Color.Red;
            this.msg.Location = new System.Drawing.Point(466, 111);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 24);
            this.msg.TabIndex = 43;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateBtn.Location = new System.Drawing.Point(249, 1022);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(160, 47);
            this.UpdateBtn.TabIndex = 44;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackBtn.Location = new System.Drawing.Point(558, 1022);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 47);
            this.BackBtn.TabIndex = 45;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // SeleEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(986, 1097);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.ey);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.em);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.usedleaves);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalleaves);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addr2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addr1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Title);
            this.Name = "SeleEmpForm";
            this.Text = "SeleEmpForm";
            this.Load += new System.EventHandler(this.SeleEmpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox img;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addr1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addr2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalleaves;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox usedleaves;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox dm;
        private System.Windows.Forms.TextBox dy;
        private System.Windows.Forms.TextBox ey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ed;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}