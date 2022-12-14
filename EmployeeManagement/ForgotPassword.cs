using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace EmployeeManagement
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmailAddressInput_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // ask user to provide email address if there is no valid input email
            // if valid input email, then check if the email exists in DB
            // if the email does not exist in DB, tell user email does not exist, ask the user to enter gain
            // if the email exists
            // generate random password
            // update new password for user in DB
            // send new password to user email
            Operator ope = new Operator();
            if (ope.IsValidEmail(txtEmailAddress.Text))
            {
                string sql = "SELECT email FROM account WHERE email='" + txtEmailAddress.Text + "'";
                MySqlConnection con = ope.getMySqlConnection();
                try
                {
                    con.Open();
                    MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                    if (rdr.HasRows)
                    {

                        ope.sendMail(txtEmailAddress.Text).Wait(10);
                    }
                    else
                    {
                        ope.displayMessageBox("Email doesn't exist in RECA HRS system.\nPlease input again to continue!");
                    }

                    rdr.Close();
                }
                catch (Exception ex)
                {
                    ope.displayMessageBox("error:\n" + ex.ToString());
                }
                con.Close();

            }
            else
            {
                ope.displayMessageBox("It is not a valid email. Please input your email address again!");            
            }
        }
    }
}
