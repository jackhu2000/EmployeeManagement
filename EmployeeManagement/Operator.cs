using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


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
            string randomPassword = "";


            return randomPassword;
        }


        public MySqlConnection getMySqlConnection()
        {
            return new MySqlConnection(this.getConnectionString());
        }

        public int nonQueryExection(string sql)
        {
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
            
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
