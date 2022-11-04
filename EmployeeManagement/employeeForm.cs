using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class employeeForm : Form
    {
        private string username;
        public employeeForm(string loginName)
        {
            InitializeComponent();
            username = loginName;
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPasswordUpdate passWordUpdateForm = new frmPasswordUpdate(this.username);
            passWordUpdateForm.Show();
        }
    }
}
