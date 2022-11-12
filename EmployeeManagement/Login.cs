using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace EmployeeManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login button click handling


            string sql = "SELECT username, password, isAdmin FROM account WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";

            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                if (rdr.HasRows)
                {
                    rdr.Read();
                    bool isAdmin = (bool)rdr[2];
                    string username = rdr[0].ToString();
                    if (isAdmin)
                    {
                        adminForm adminForm = new adminForm(username);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {

                        employeeForm employeForm = new employeeForm(username);
                        employeForm.Show();
                        this.Hide();
                        //JUST FOR TEST
                        //MsgListForm msgListForm = new MsgListForm();
                        //msgListForm.Show();
                        //this.Hide();
                    }
                }
                else
                {
                    ope.displayMessageBox("Wrong Username and/or Password");
                }
                
                rdr.Close();
            }
            catch (Exception ex)
            {
                ope.displayMessageBox("error:\n" + ex.ToString());
            }
            con.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUser();
            createUserForm.Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword emailAddressInput = new frmForgotPassword();
            emailAddressInput.Show();           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
