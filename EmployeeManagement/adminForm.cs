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
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //TODO: the argument should be from list view selection
            //just for testing
            SeleEmpForm seleEmpForm = new SeleEmpForm("RE00001");
            seleEmpForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO: the argument should be from list view selection
            //testing
            string sql = "Delete from account where username='RE00500'";
            Operator ope = new Operator();
            if (ope.nonQueryExection(sql) != -1)
            {
                ope.displayMessageBox("Successfully deleted user!");
            }
        }

        private void msglst_Click(object sender, EventArgs e)
        {
            MsgListForm msgListForm= new MsgListForm();
            msgListForm.ShowDialog();
        }
    }
}
