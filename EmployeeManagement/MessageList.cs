using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text;

namespace EmployeeManagement
{
    internal class MessageList
    {
        private ArrayList msglst;


        public MessageList() 
        {  
            msglst = new ArrayList();
            String sql = "SELECT account.FirstName,account.LastName,account.Department,message.* FROM account, message WHERE message.EmployeeID=account.username AND message.stat = 1;";
            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                while(rdr.Read())
                {
                    Message message = new Message(rdr.GetString("Message"),rdr.GetString("EmployeeID"),String.Format("{0} {1}({2})",rdr.GetString("FirstName"),rdr.GetString("LastName"),rdr.GetString("Department")),rdr.GetString("stat"),rdr.GetString("MessageID"));
                    msglst.Add(message);
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

        public ArrayList getMsglst()
        {
            return msglst;
        }

        public void chgMsgStat(Message message,String stat)
        {
            foreach(Message msg in msglst)
            {
                if(msg==message)
                {
                    msg.setState(stat);
                }
            }
        }

        public Message getMsgByID(String id)
        {
            foreach(Message msg in msglst)
            {
                if(msg.messageID.Equals(id))
                {
                    return msg;
                }
            }
            return null;
        }

        public bool UpdateState()
        {
            String sql = "(";
            foreach(Message message in msglst)
            {
                if(message.state=="0")
                {
                    sql = sql + message.messageID + ",";
                }
            }
            sql=sql.Remove(sql.Length-1,1);
            sql=sql+");";
            sql = "UPDATE message SET stat = 0 WHERE EmployeeID in " + sql;

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
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }

        }
        

    }
}
