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

        
        
        public Operator()
        {
        }
        public string getConnectionString()
        {
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

       


    }
}
