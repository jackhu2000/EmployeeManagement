using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;

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

        /*public void setLoginInfo(string username)
        {
            //remember login username
            login.Add("username:", username);
        }
       
        public string getLoginUsername()
        {
            //return login username
            return login["username"];
        }
        */


    }
}
