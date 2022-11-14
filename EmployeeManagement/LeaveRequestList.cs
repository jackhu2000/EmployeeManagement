using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class LeaveRequestList
    {
        public ArrayList lrl;
        public LeaveRequestList()
        {
            lrl=new ArrayList();
        }

        public void rf()
        {
            lrl.Clear();
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            String sql = "SELECT account.username,account.FirstName,account.LastName,account.Department,leavereq.* FROM leavereq,account WHERE leavereq.res = 0 AND account.username = leavereq.EmployeeID";
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                while(rdr.Read())
                {
                    lrl.Add(new LeaveRequest(rdr.GetString("reason"),String.Format("{0} {1}({2})", rdr.GetString("FirstName"), rdr.GetString("LastName"), rdr.GetString("Department")),rdr.GetString("reqid"), rdr.GetDateTime("time").ToString("yyyy-MM-dd"), rdr.GetString("username"), rdr.GetDateTime("etime").ToString("yyyy-MM-dd")));
                }
                rdr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                ope.displayMessageBox(ex.Message);
            }
        }

        public LeaveRequest getLRByID(String reqid)
        {
            foreach(LeaveRequest lr in lrl)
            {
                if (lr.nreqid.Equals(reqid))
                    return lr;
            }
            return null;
        }
    }
}
