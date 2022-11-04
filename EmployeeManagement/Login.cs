using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EmployeeManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                    }                    
                }
                else
                {
                    MessageBox.Show("Wrong Username and/or Password");
                }
                
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
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
            // todo:
            // ask user to provide email
            // generate random password
            // update new email for user in DB
            // send new password to user email
            
            sendMail().Wait(1);
            MessageBox.Show("Email sent");
            
        }

        async Task sendMail()
        {

            var apikey = Environment.GetEnvironmentVariable("apikey");
            var client = new SendGridClient(apikey);
            var from = new EmailAddress("764701917@nzse.ac.nz", "RECA admin");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("keosophon8888@gmail.com", "keo sophon");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            
         
        }

    }
}
