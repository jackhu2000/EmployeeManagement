using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EmployeeManagement
{
    public class LeaveRequest
    {
        public String reason;
        public String username;
        public bool isR;
        public String nreqid;
        public String shortinfo;
        public String date;
        public String edate;
        public String duration;
        int i;
        public LeaveRequest(String username) 
        { 
            this.username = username;
            i = 0;
            reason = "";
            isR = false;
        }

        public LeaveRequest(String reason, String shortinfo, String nreqid, String date, String username, String edate) 
        { 
            this.reason= reason;
            this.shortinfo= shortinfo;
            this.nreqid= nreqid;
            this.date= date;
            this.username= username;
            this.edate= edate;
        }

        public bool isRequest()
        {
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            String sql = String.Format("SELECT * FROM  leavereq WHERE EmployeeID = '{0}' ORDER BY time", username);
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                while (rdr.Read())
                {
                    if (rdr.GetInt16("res") == 0)
                    {
                        reason = rdr.GetString("reason");
                        isR = true;
                        nreqid = rdr.GetString("reqid");
                        date = rdr.GetDateTime("time").ToString("yyyy-MM-dd");
                        edate = rdr.GetDateTime("etime").ToString("yyyy-MM-dd");
                        duration = rdr.GetString("duration");
                    }
                    i++;
                }
                rdr.Close();
                return isR;
            }
            catch (Exception e)
            {
                ope.displayMessageBox(e.Message);
                return false;
            }
        }

        public bool Update(int resid, String adminname)
        //resid :
        //0 : wait for review
        //1 : Accept by admin
        //2 : Reject by admin
        //3 : Revoke by Employee
        {
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            String sql = String.Format("UPDATE leavereq SET res = {0}, reviewer = '{1}' WHERE reqid='{2}'", resid, adminname, nreqid);
            Debug.WriteLine(sql);
            try
            {
                con.Open();
                int res = ope.nonQueryExection(sql);
                if (res == 1)
                {
                    if(resid!=1)
                    {
                        con.Close();
                        return true;
                    }
                    sql = String.Format("UPDATE account SET UsedLeaves = UsedLeaves + 1 WHERE username = '{0}'", username);
                    res = ope.nonQueryExection(sql);
                    if (res == 1)
                    {
                        con.Close();
                        return true;
                    }
                }
                con.Close();
                return false;
            }
            catch (Exception e)
            {
                ope.displayMessageBox(e.Message);
                con.Close();
                return false;
            }
        }

        public bool Upload()
        {
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            String reqid = String.Format("{0}{1:d5}", username, i);
            String sql = String.Format("INSERT INTO leavereq SET reqid = '{0}', time=DATE('{1}'), res = 0, EmployeeID = '{2}', reason = '{3}', etime=DATE('{4}'), duration = {5}", reqid, date, username,reason, edate, duration);
            try
            {
                con.Open();
                int res = ope.nonQueryExection(sql);
                if(res==1)
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch(Exception e)
            {
                ope.displayMessageBox(e.Message); 
                con.Close();
                return false;
            }
        }
    }
}
