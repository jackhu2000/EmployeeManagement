using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace EmployeeManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string cs = @"server=sql6.freesqldatabase.com;port=3306;userid=sql6527607;password=t4Rtas3nkN;database=sql6527607";
            using var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string sql = "SELECT username, password, role FROM account WHERE username='" + username + "' AND password='" + password + "'" ;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    string priviledge = rdr[2].ToString();
                    if (priviledge == "a")
                    {
                        adminForm adminForm = new adminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        employeeForm employeForm = new employeeForm();
                        employeForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                }
                
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }
            con.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUser();
            createUserForm.Show();
            this.Hide();
        }
    }
}
