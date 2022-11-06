using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Net.Mail;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;



namespace EmployeeManagement
{
    public class Operator
    {

        //private NameValueCollection login = new NameValueCollection();
        
        public Operator()
        {
        }
        public string getConnectionString()
        {
            //return connection string to Azure DB server from config file
            //and from environment variable
            string cs = "";
            // Read all the keys from the config file
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;
            foreach (string key in sAll.AllKeys)
            {
                if (key == "userid" || key == "password")
                {
                    cs += key + "=" + Environment.GetEnvironmentVariable(key) + ";";
                }

                else
                {
                    cs += key + "=" + sAll.Get(key) + ";";
                }

            }

            cs = @cs.Substring(0, cs.Length - 1);
            return cs;
        }

        public string createRandomPassword()
        {
            string createRandomString(int size, bool lowerCase)
            {
                StringBuilder stringBuilder1 = new StringBuilder();
                Random random = new Random();
                char ch;
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    stringBuilder1.Append(ch);
                }
                if (lowerCase) return stringBuilder1.ToString().ToLower();
                return stringBuilder1.ToString();
            }

            int createRandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(createRandomString(4, true));
            stringBuilder.Append(createRandomNumber(1000, 9999));
            stringBuilder.Append(createRandomString(2, false));
            
            return stringBuilder.ToString();
        }


        public MySqlConnection getMySqlConnection()
        {
            return new MySqlConnection(this.getConnectionString());
        }

        public int nonQueryExection(string sql)
        {
            //this funciton for executing INSERT, UPDATE or DELETE in database

            MySqlConnection con = this.getMySqlConnection();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int returnVal = cmd.ExecuteNonQuery();
                con.Close();
                return returnVal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
                return -1;
            }

        }

        public MySqlDataReader getMySqlDataReader(string sql, MySqlConnection con)
        {
            //use for SELECT sql command

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

   


        public async Task sendMail(string toEmail)
        {
                        var newPassword = this.createRandomPassword();


            string apikey = Environment.GetEnvironmentVariable("apikey");
            var client = new SendGridClient(apikey);
            var from = new EmailAddress("764701917@nzse.ac.nz", "Administrator");
            var subject = "New Password";
            var to = new EmailAddress(toEmail);
            
            var plainTextContent = "Here is your new password: " + newPassword;
            var htmlContent = "<strong>Here is your new password: " + newPassword + "</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            if (response.IsSuccessStatusCode)
            {
                string sql = "update account set password='" + newPassword + "' " + "where email='" + toEmail + "' " + ";";
                this.nonQueryExection(sql);
                MessageBox.Show("Sending mail succeeded!");
            }
            else
            {
                MessageBox.Show("Sending mail failed!");
            }
        }
    }
}
