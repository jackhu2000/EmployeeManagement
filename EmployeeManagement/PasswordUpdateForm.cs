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
            Operator ope = new Operator();
            if (txtOldPassWord.Text == "" || txtNewPassWord.Text == "" || txtConfirmNewPassWord.Text == "")
            {
                ope.displayMessageBox("Please input Old Password, New Password and Confirm!");                
                return;
            }
            if (txtConfirmNewPassWord.Text != txtNewPassWord.Text)
            {
                ope.displayMessageBox("Confirm input must be the same as New Password input");
                return;
            }
            if (txtOldPassWord.Text == txtNewPassWord.Text)
            {
                ope.displayMessageBox("New Password cannot be the same as Old Password");
                return;
            }

            if (txtNewPassWord.Text.Length < 8)
            {
                ope.displayMessageBox("Your password should be 8-character length");
                return;
            }

           
            string sql = "update account set password='" + txtNewPassWord.Text + "' " + "where username='" + this.username + "' " + ";";
            if (ope.nonQueryExection(sql) != -1)
            {
                ope.displayMessageBox("Successfully updated new password!");
            }       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
