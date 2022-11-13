
namespace EmployeeManagement
{
    partial class adminForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Username = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Date_Of_Birth = new System.Windows.Forms.ColumnHeader();
            this.AddressLine1 = new System.Windows.Forms.ColumnHeader();
            this.AddressLine2 = new System.Windows.Forms.ColumnHeader();
            this.City = new System.Windows.Forms.ColumnHeader();
            this.Phone = new System.Windows.Forms.ColumnHeader();
            this.Department = new System.Windows.Forms.ColumnHeader();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.msglst = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;

            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.FirstName,
            this.LastName,
            this.Date_Of_Birth,
            this.AddressLine1,
            this.AddressLine2,
            this.City,
            this.Phone,
            this.Department});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(881, 376);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            // 
            // Date_Of_Birth
            // 
            this.Date_Of_Birth.Text = "Date of Birth";
            // 
            // AddressLine1
            // 
            this.AddressLine1.Text = "Address1";
            // 
            // AddressLine2
            // 
            this.AddressLine2.Text = "Address2";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            // 
            // Department
            // 
            this.Department.Text = "Department";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDetails.Location = new System.Drawing.Point(916, 101);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(83, 25);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "&Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.Location = new System.Drawing.Point(916, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "De&lete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(916, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogout.Location = new System.Drawing.Point(916, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 25);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "&Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchEmployee.Location = new System.Drawing.Point(916, 61);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(83, 25);
            this.btnSearchEmployee.TabIndex = 8;
            this.btnSearchEmployee.Text = "&Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // msglst
            // 
            this.msglst.BackColor = System.Drawing.Color.SkyBlue;
            this.msglst.Location = new System.Drawing.Point(916, 231);
            this.msglst.Name = "msglst";
            this.msglst.Size = new System.Drawing.Size(83, 25);
            this.msglst.TabIndex = 9;
            this.msglst.Text = "&Message";
            this.msglst.UseVisualStyleBackColor = false;
            this.msglst.Click += new System.EventHandler(this.msglst_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRefresh.Location = new System.Drawing.Point(916, 274);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 25);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click)
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1022, 559);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.msglst);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button msglst;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Date_Of_Birth;
        private System.Windows.Forms.ColumnHeader AddressLine1;
        private System.Windows.Forms.ColumnHeader AddressLine2;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.Button btnRefresh;
    }
}