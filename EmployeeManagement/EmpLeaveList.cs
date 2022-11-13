using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmpLeaveList : Form
    {

        private LeaveRequestList lrl;
        private String username;
        public EmpLeaveList(String username)
        {
            InitializeComponent();
            lrl = new LeaveRequestList();
            this.username= username;
            rf();
        }

        public void rf()
        {
            lrl.rf();
            lrview.Items.Clear();
            lrview.BeginUpdate();
            foreach(LeaveRequest lr in lrl.lrl)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = lr.shortinfo;
                if (lr.reason.Length <= 50)
                    lvi.SubItems.Add(lr.reason);
                else
                    lvi.SubItems.Add(lr.reason.Remove(50,lr.reason.Length-50)+"...");
                lvi.SubItems.Add(lr.nreqid);
                lrview.Items.Add(lvi);
            }
            lrview.EndUpdate();
        }

        private void lrview_DoubleClick(object sender, EventArgs e)
        {
            LeaveRequest lr = lrl.getLRByID(lrview.SelectedItems[0].SubItems[2].Text);
            if (lr != null)
            {
                EmpLeaveDtl empLeaveDtl = new EmpLeaveDtl(lr,username);
                empLeaveDtl.ShowDialog();
                lrview.Items.Remove(lrview.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Unknown Error!");
            }
        }

        private void rfbtn_Click(object sender, EventArgs e)
        {
            rf();
        }

        private void bkbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
