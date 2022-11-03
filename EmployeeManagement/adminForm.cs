using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class adminForm : Form
    {
        private string username;
        public adminForm(string loginName)
        {
            InitializeComponent();
            username = loginName;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
