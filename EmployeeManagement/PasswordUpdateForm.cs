using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EmployeeManagement
{
    public partial class frmPasswordUpdate : Form
    {
        private string username;
        
        public frmPasswordUpdate(string loginName)
        {
            InitializeComponent();
            this.username = loginName;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtOldPassWord.Text == "" || txtNewPassWord.Text == "" || txtConfirmNewPassWord.Text == "")
            {
                MessageBox.Show("Please input Old Password, New Password and Confirm!");
                return;
            }
            if (txtConfirmNewPassWord.Text != txtNewPassWord.Text)
            {
                MessageBox.Show("Confirm input must be the same as New Password input");
                return;
            }
            if (txtOldPassWord.Text == txtNewPassWord.Text)
            {
                MessageBox.Show("New Password cannot be the same as Old Password");
                return;
            }

            if (txtNewPassWord.Text.Length < 8)
            {
                MessageBox.Show("Your password should be 8-character length");
                return;
            }

            Operator ope = new Operator();
            string sql = "update account set password='" + txtNewPassWord.Text + "' " + "where username='" + this.username + "' " + ";";
            if (ope.nonQueryExection(sql) != -1)
            {
                MessageBox.Show("Successfully updated new password!");
            }       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
