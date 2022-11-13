using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmpLeaveDtl : Form
    {

        LeaveRequest lr;
        String adminname;
        public EmpLeaveDtl()
        {
            InitializeComponent();
        }

        public EmpLeaveDtl(LeaveRequest lr, String adminname)
        {
            InitializeComponent();
            this.lr = lr;
            content.Text = lr.reason;
            nl.Text = lr.shortinfo;
            el.Text = lr.username;
            Notify.Text = "";
            this.adminname = adminname;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rejc_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rejc_Click(object sender, EventArgs e)
        {
            if (rejc.Checked)
            {
                rejbtn.Enabled = true;
                accc.Checked = false;
                accbtn.Enabled = false;
            }
            else
            {
                rejbtn.Enabled = false;
                accc.Checked = true;
                accbtn.Enabled = true;
            }
        }

        private void accc_Click(object sender, EventArgs e)
        {
            if(accc.Checked)
            {
                accbtn.Enabled = true;
                rejbtn.Enabled = false;
                rejc.Checked= false;
            }
            else
            {
                accbtn.Enabled = false;
                rejc.Checked = true;
                rejbtn.Enabled = true;
            }
        }

        private void rejbtn_Click(object sender, EventArgs e)
        {
            bool res = lr.Update(2, adminname);
            if(res)
            {
                Notify.Text = "Success !";
                accbtn.Visible = false;
                accc.Visible = false;
                rejbtn.Visible = false;
                rejc.Visible = false;
            }
            else
            {
                MessageBox.Show("Unknown Error!");
            }
        }

        private void accbtn_Click(object sender, EventArgs e)
        {
            bool res = lr.Update(1, adminname);
            if (res)
            {
                Notify.Text = "Success !";
                accbtn.Visible = false;
                accc.Visible = false;
                rejbtn.Visible = false;
                rejc.Visible = false;
            }
            else
            {
                MessageBox.Show("Unknown Error!");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
