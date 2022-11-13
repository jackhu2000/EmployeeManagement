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
    public partial class adminForm : Form
    {
        private string username;
        private List<string[]> userList;

        public adminForm(string loginName)
        {
            InitializeComponent();
            username = loginName;

            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            userList = new UserList().getUserList();
            listView1.BeginUpdate();
            foreach(string[] user in userList)
            {
                ListViewItem item = new ListViewItem(user);
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();

        }
        private void adminForm_Load(object sender, EventArgs e)
        {


            //User user = new User();
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchEmployee searchEmployee = new SearchEmployee();
            searchEmployee.Show();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str = "";
            int val = 0;

            
            string sql = "SELECT username FROM hrs.account ORDER BY username DESC LIMIT 1;";

            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();

            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                if (rdr.HasRows)
                {
                    rdr.Read();
                    str = rdr[0].ToString();
                                      
                    string str2 = string.Empty;
                   
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (Char.IsDigit(str[i]))
                            str2 += str[i];
                    }
                    if (str2.Length > 0) val = int.Parse(str2) + 1;

                }
                else
                {
                    str = "RE00001";
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                ope.displayMessageBox("error:\n" + ex.ToString());
            }
            con.Close();

            string str3 = val.ToString();
            for (int i = 0; i <= 5 - str3.Length; i++)
            {
                    str3 = "0" + str3;
            }


            str3 = "RE" + str3;
            sql = "INSERT INTO hrs.account VALUES('" + str3 + "',  '',  '', '', '1/1/2000', '', '', '', '', '', '', '0', '0', '0', '0','1/1/2000', '0','', '');";

            MySqlConnection con1 = ope.getMySqlConnection();

            if (ope.nonQueryExection(sql) != -1)
            {
                SeleEmpForm NewEmpForm = new SeleEmpForm(str3);
                NewEmpForm.Show();
            }
             else
            {
                ope.displayMessageBox("Unable to add new record to the database...");
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SeleEmpForm seleEmpForm = new SeleEmpForm(listView1.SelectedItems[0].Text);
                seleEmpForm.Show();
            }
            else
            {
                Operator ope = new Operator();
                ope.displayMessageBox("Please select an employee in the list to see his/her details!");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Operator ope = new Operator();
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedUser = listView1.SelectedItems[0].Text;
                if (username == selectedUser)
                {
                    ope.displayMessageBox("User cannot be deleted while in login state");
                }
                else
                {
                    string sql = "Delete from account where username='" + selectedUser + "'";
                    if (ope.nonQueryExection(sql) != -1)
                    {
                        int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                        userList.RemoveAt(index);
                        listView1.Items.Clear();
                        listView1.BeginUpdate();
                        foreach (string[] user in userList)
                        {
                            ListViewItem item = new ListViewItem(user);
                            listView1.Items.Add(item);
                        }
                        listView1.EndUpdate();

                    }
                }
                
            }
            else
            {
                ope.displayMessageBox("Please select an employee that needs to be deleted in the list!");
            }

      
        }

        private void msglst_Click(object sender, EventArgs e)
        {
            MsgListForm msgListForm= new MsgListForm();
            msgListForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmpLeaveList empLeaveList = new EmpLeaveList(username);
            empLeaveList.ShowDialog();
        }
    }
}
