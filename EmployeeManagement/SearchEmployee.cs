using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Operator ope = new Operator();
            if (txtUsername.Text != "")
            {
                SeleEmpForm seleEmpForm = new SeleEmpForm(txtUsername.Text);
                seleEmpForm.Show();
                this.Close();
            }
            else
            {
                ope.displayMessageBox("Please input username!");
            }
            
        }
    }
}
