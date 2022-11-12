using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;


namespace EmployeeManagement
{
    class UserList
    {
        private List<string[]> userList = new List<string[]>();
        
        
        public UserList()
        {
            string sql = "SELECT username, FirstName, LastName, DoB, AddressLine1, AddressLine2, City , Phone, Department FROM account";

            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                while (rdr.Read())
                {
                    
                    
                   string[] user = new string[]{ rdr.GetString("username"), rdr.GetString("FirstName"), rdr.GetString("LastName"), rdr.GetString("DoB") , rdr.GetString("AddressLine1"), rdr.GetString("AddressLine2"), rdr.GetString("City"), rdr.GetString("Phone"), rdr.GetString("Department")  };
                   userList.Add(user);
                }
                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                ope.displayMessageBox(ex.ToString());
                con.Close();
            }
        }
        public List<string[]> getUserList()
        {
            return userList;
        }
    }
}
