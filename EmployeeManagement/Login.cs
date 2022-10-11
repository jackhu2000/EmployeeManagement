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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string cs = @"server=localhost;port=3306;userid=root;password=Sophon123;database=employee_management";
            using var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string sql = "SELECT username, password, priviledge FROM account WHERE username='" + username + "' AND password='" + password + "'" ;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    string priviledge = rdr[2].ToString();
                    if (priviledge == "admin")
                    {
                        Form1 adminForm = new Form1();
                        adminForm.Show();
                    }
                    else
                    {
                        Form3 employeForm = new Form3();
                        employeForm.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
