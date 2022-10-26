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
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check if user name is exist
            // if exist, alert username already exist
            // if not exist, check if the password and confirm is the same
            // if not the same alert password not the same
            // if the same, create user new user
            // close create user form
            // show login form


            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            Operator engine = new Operator();
            string cs = engine.getConnectionString();
            using var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string sql = "SELECT username FROM account WHERE username='" + username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    MessageBox.Show("Username already exists. Please input again!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtConfirm.Clear();
                    txtUsername.Focus();
                    rdr.Close();
                    con.Close();
                }
                else
                {
                    if (txtUsername.Text != "")
                    {
                        if (txtPassword.Text != txtConfirm.Text)
                        {
                            MessageBox.Show("Password and Confirm must be the same. Please input again!");
                            txtPassword.Clear();
                            txtConfirm.Clear();
                            txtPassword.Focus();
                        }
                        else
                        {
                            rdr.Close();
                            string insertSql = "insert into account(username,password) values(@name,@pass)";
                            MySqlCommand insertCmd = new MySqlCommand(insertSql, con);
                            insertCmd.Parameters.AddWithValue("@name", txtUsername.Text);
                            insertCmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("User account succesfully created");
                            Form login = new frmLogin();
                            login.Show();
                            this.Close();
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }
            
        }
    }
}
