using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class MsgDtlForm : Form
    {
        Message msg;
        public MsgDtlForm()
        {
            InitializeComponent();
        }

        public MsgDtlForm(Message msg)
        {
            InitializeComponent();
            this.msg = msg;
            MsgBox.Text = msg.content+"\nBy:"+msg.shortinfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operator ope = new Operator();
            String sql = String.Format("UPDATE message SET stat=0 WHERE MessageID = {0}", msg.messageID);
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                int res = ope.nonQueryExection(sql);
                if (res == 0)
                {
                    ope.displayMessageBox("Internet Error!");
                }
                con.Close();
                notify.Text = "DONE!";
                button1.Enabled= false;
            }
            catch (Exception ex)
            {
                ope.displayMessageBox(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
