using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class frmMesasge : Form
    {
        private string user;
        public frmMesasge(string userID)
        {
            InitializeComponent();
            user = userID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Operator ope = new Operator();
            if (txtMessage.Text == "")
            {
                ope.displayMessageBox("Please input your message or feedback in the text box");
                return;
            }
            
            string sql = "insert into message(Message,EmployeeID) values('" + txtMessage.Text + "'" + ", '" + user  + "')" + ";";
            MessageBox.Show(sql);
            if (ope.nonQueryExection(sql) != -1)
            {
                ope.displayMessageBox("Your message or feedback is successfully sent");
                this.Close();
            }


        }
    }
}
