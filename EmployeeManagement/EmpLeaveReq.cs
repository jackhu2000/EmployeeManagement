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
        String un = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 _.@/:-%&=,";
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
                if(!canup)
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
    }
}
