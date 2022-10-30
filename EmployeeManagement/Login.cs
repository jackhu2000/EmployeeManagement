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


namespace EmployeeManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Operator engine = new Operator();
            string cs = engine.getConnectionString();
            using var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string sql = "SELECT username, password, isAdmin FROM account WHERE username='" + username + "' AND password='" + password + "'" ;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    bool role = (bool)rdr[2];
                    if (role)
                    {
                        adminForm adminForm = new adminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        employeeForm employeForm = new employeeForm();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            // todo:
            // ask user to provide email
            // generate random password
            // update new email for user in DB
            // send new password to user email
            
            MessageBox.Show("Sending email");
            sendMail().Wait(1);
            MessageBox.Show("Email sent");
            
        }

        async Task sendMail()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
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
