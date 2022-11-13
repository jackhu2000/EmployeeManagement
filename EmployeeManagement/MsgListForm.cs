using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//************************************
// Double Click to see Message Detail
//************************************
namespace EmployeeManagement
{
    public partial class MsgListForm : Form
    {
        private String seleIndex = "-1";
        private MessageList msglst;
        public MsgListForm()
        {
            InitializeComponent();
            msglst = new MessageList();
            msgl.BeginUpdate();
            foreach (Message msg in msglst.getMsglst())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = msg.shortinfo.ToString();
                if (msg.content.Length <= 50)
                {
                    lvi.SubItems.Add(msg.content);
                    Debug.WriteLine(msg.content.ToString());
                }
                else
                {
                    String s = msg.content.Remove(50, msg.content.Length - 50) + "...";
                    lvi.SubItems.Add(s);
                    Debug.WriteLine(s);
                }
                lvi.SubItems.Add(msg.messageID.ToString());
                msgl.Items.Add(lvi);
            }
            msgl.EndUpdate();
        }

        public void rf()
        {
            msglst = new MessageList();
            msgl.Items.Clear();
            msgl.BeginUpdate();
            foreach (Message msg in msglst.getMsglst())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = msg.shortinfo.ToString();
                if (msg.content.Length <= 50)
                {
                    lvi.SubItems.Add(msg.content);
                    Debug.WriteLine(msg.content.ToString());
                }
                else
                {
                    String s = msg.content.Remove(50, msg.content.Length - 50) + "...";
                    lvi.SubItems.Add(s);
                    Debug.WriteLine(s);
                }
                lvi.SubItems.Add(msg.messageID.ToString());
                msgl.Items.Add(lvi);
            }
            msgl.EndUpdate();
        }

        private void msgl_Click(object sender, EventArgs e)
        {
            if (seleIndex.Equals(msgl.SelectedItems[0].SubItems[2].Text))
            {
                Message smsg = msglst.getMsgByID(seleIndex);
                if (smsg != null) 
                {
                    MsgDtlForm msgDtlForm = new MsgDtlForm(smsg);
                    msgDtlForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unknown Error!");
                }
                
            }
            else
            {
                seleIndex = msgl.SelectedItems[0].SubItems[2].Text;
            }

        }

        private void msgl_DoubleClick(object sender, EventArgs e)
        {
                Message smsg = msglst.getMsgByID(msgl.SelectedItems[0].SubItems[2].Text);
                if (smsg != null)
                {
                    MsgDtlForm msgDtlForm = new MsgDtlForm(smsg);
                    msgDtlForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unknown Error!");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rf();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
