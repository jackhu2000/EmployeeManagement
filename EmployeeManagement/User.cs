using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EmployeeManagement
{
    internal class User
    {
        private Dictionary<String,String> userDict = new Dictionary<String, String>();
        private bool isInit = false;
        private ArrayList qindexName;
        private ArrayList uindexName;


        public User(String username)
        {
            qindexName= new ArrayList();
            uindexName = new ArrayList();
            qindexName.Add("username");
            qindexName.Add("password");
            qindexName.Add("FirstName");
            qindexName.Add("LastName");
            qindexName.Add("DoB");
            qindexName.Add("AddressLine1");
            qindexName.Add("AddressLine2");
            qindexName.Add("City");
            qindexName.Add("Phone");
            qindexName.Add("Department");
            qindexName.Add("Role");
            uindexName.Add("Salary");
            uindexName.Add("TotalLeave");
            uindexName.Add("UsedLeaves");
            uindexName.Add("Grade");
            qindexName.Add("EmploymentStartDate");
            uindexName.Add("isAdmin");
            qindexName.Add("email");
            qindexName.Add("imgUrl");
            String sql = String.Format("SELECT * FROM hrs.account WHERE username='{0}';", username);
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                if(rdr.HasRows)
                {
                    rdr.Read();
                    foreach(String index in qindexName)
                    {
                        try
                        {
                            String value = rdr.GetString(index);
                            this.userDict.Add(index, value);
                        }
                        catch
                        {
                            this.userDict.Add(index, "");
                        }
                    }
                    foreach (String index in uindexName)
                    {
                        try
                        {
                            String value = rdr.GetString(index);
                            this.userDict.Add(index, value);
                        }
                        catch
                        {
                            this.userDict.Add(index, "");
                        }
                    }
                    this.isInit = true;
                }
                rdr.Close();
                con.Close();
            }
            catch
            {
                if(con.State== System.Data.ConnectionState.Open) { }
                con.Close();
            }
        }

        public Dictionary<String,String> getInfo()
        {
            return this.userDict;
        }

        public String get_short()
        {
            return String.Format("{0} {1}({2})", userDict["FirstName"], userDict["LastName"], userDict["Department"]);
        }

        public bool get_isInit()
        {
            return isInit;
        }

        public bool updateInfo(Dictionary<String,String> newInfo,String username)
        {
            String tempsql = "";
            foreach(String key in newInfo.Keys)
            {
                if(uindexName.Contains(key))
                    tempsql = tempsql + String.Format("{0} = {1},", key, newInfo[key]);
                else if(qindexName.Contains(key))
                    tempsql = tempsql + String.Format("{0} = '{1}',", key, newInfo[key]);
            }
            
            tempsql = tempsql.Remove(tempsql.Length - 1, 1);
            Debug.WriteLine(tempsql);
            String sql = String.Format("UPDATE hrs.account SET {0} WHERE username='{1}'",tempsql,username);
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                int res = ope.nonQueryExection(sql);
                if (res == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
