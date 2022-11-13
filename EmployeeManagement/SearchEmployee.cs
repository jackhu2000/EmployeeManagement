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
                User user = new User(txtUsername.Text);
                if (user.get_isInit())
                {
                    SeleEmpForm seleEmpForm = new SeleEmpForm(txtUsername.Text);
                    seleEmpForm.Show();
                    this.Close();
                }
                else
                {
                    ope.displayMessageBox("Cannot find user!");
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
                
            }
            else
            {
                ope.displayMessageBox("Please input username!");
            }
            
        }
    }
}
