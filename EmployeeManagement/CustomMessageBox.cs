using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public CustomMessageBox(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
