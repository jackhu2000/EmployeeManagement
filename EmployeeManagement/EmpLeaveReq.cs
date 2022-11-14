using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmpLeaveReq : Form
    {
        private bool isFirstClick;
        private LeaveRequest request;
        private bool init;
        private bool canup;
        private bool canup2;
        String un = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 _.@/:-%&=,";
        String n = "123456789";
        public EmpLeaveReq()
        {
            InitializeComponent();
            isFirstClick = true;
        }

        public EmpLeaveReq(String username)
        {
            InitializeComponent();
            init = true;
            canup = true;
            canup2 = false;
            isFirstClick = true;
            request = new LeaveRequest(username);
            if(request.isRequest())
            {
                surecheck.Visible = false;
                uploadbtn.Text = "Revoke";
                uploadbtn.Enabled = true;
                reason.Text = request.reason;
                reason.Enabled = false;
                reason.ForeColor = System.Drawing.Color.Black;
                isFirstClick = false;
                DateTime dt = DateTime.ParseExact(request.date, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                expire.Text = request.duration.ToString();
                st.Value = dt;
            }
            init = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void surecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (surecheck.Checked == true)
                uploadbtn.Enabled = true;
            else
                uploadbtn.Enabled = false;
        }

        private void reason_Click(object sender, EventArgs e)
        {
            if(isFirstClick)
            {
                reason.Text = "";
                isFirstClick = false;
                reason.ForeColor = System.Drawing.Color.Black;
            }
                
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            
            if(request.isR)
            {
                
                bool res = request.Update(3, "selfcancel");
                if (res == false)
                {
                    MessageBox.Show("Revoke Failed, Please check the Internet Connection or Contact with the Administrator.");
                    Notify.Text = "Revoke Failed!";
                }
                else
                {
                    uploadbtn.Visible = false;
                    Notify.Text = "Revoke Success!";
                }
            }

            else
            {
                if (!canup2)
                {
                    Notify.Text = "Wrong Expire Format!";
                    return;
                }
                DateTime nowtime = st.Value;
                if (DateTime.Compare(nowtime, DateTime.Now.AddDays(-1)) < 0)
                {
                    Notify.Text = String.Format("StartTime must on or after TODAY");
                    return;
                }
                else
                {
                    request.date = nowtime.ToString("yyyy-MM-dd");
                    request.edate = nowtime.AddDays(int.Parse(expire.Text)).ToString("yyyy-MM-dd");
                    request.duration=expire.Text;
                }
                if (!canup)
                {
                    return;
                }
                if(reason.Text=="")
                {
                    Notify.Text = "Reason can't be empty";
                    return;
                }
                request.reason = reason.Text;
                bool res = request.Upload();
                if (res == false)
                {
                    MessageBox.Show("Upload Failed, Please check the Internet Connection or Contact with the Administrator.");
                    Notify.Text = "Upload Failed!";
                }

                else
                {
                    uploadbtn.Visible = false;
                    Notify.Text = "Upload Success!";
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reason_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            else
            {
                foreach (char i in reason.Text)
                {
                    if (!un.Contains(i))
                    {
                        Notify.Text = String.Format("Invaild char {0} in reason", i);
                        canup = false;
                        return;
                    }
                }
            }
            canup = true;
            Notify.Text = "";
        }

        private void EmpLeaveReq_Load(object sender, EventArgs e)
        {

        }

        private void st_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void expire_TextChanged(object sender, EventArgs e)
        {
            if(expire.Text.Length==0)
            {
                canup2= false;
                return;
            }
            foreach(char c in expire.Text)
            {
                if(!n.Contains(c))
                {
                    Notify.Text = "Wrong Expire Format!";
                    canup2= false; return;
                }
            }
            canup2= true;
        }
    }
}
