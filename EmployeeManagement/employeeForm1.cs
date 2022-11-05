using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;



namespace EmployeeManagement
{
    public partial class employeeForm1 : Form
    {
        //private string username;
        public employeeForm1()
        {
            InitializeComponent();
        }
        public employeeForm1(string loginName)
        {
            InitializeComponent();
          //  username = loginName;

            UserID.Text = loginName;


            string sql = "SELECT FirstName, LastName, Salary, TotalLeave, UsedLeaves, AddressLine1, AddressLine2, City, Phone FROM hrs.account WHERE username='" + loginName + "'";
            //string sql = "SELECT FirstName, LastName, Salary, TotalLeave FROM hrs.account WHERE username='" + loginName + "'";

            Operator ope = new Operator();
            MySqlConnection con = ope.getMySqlConnection();
            try
            {
                con.Open();
                MySqlDataReader rdr = ope.getMySqlDataReader(sql, con);
                if (rdr.HasRows)
                {
                    rdr.Read();
                    FullName.Text = rdr[0].ToString() + " " + rdr[1].ToString();
                  
                    
                    Salary.Text = "$" + rdr[2].ToString();
                    TotalLeaves.Text = rdr[3].ToString();
                    
                    UsedLeaves.Text = rdr[4].ToString();
                    Address.Text = rdr[5].ToString() + " " + rdr[6].ToString();
                    City.Text = rdr[7].ToString();
                    Phone.Text = rdr[8].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Record Not Found!");
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }
            con.Close();

           
        }


        private void employeeForm1_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    System.Windows.Forms.Application.Exit()
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create document
            PrintDocument _document = new PrintDocument();
            // Add print handler
            _document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            // Create the dialog to display results
            PrintPreviewDialog _dlg = new PrintPreviewDialog();
            _dlg.ClientSize = new System.Drawing.Size(Width / 2, Height / 2);
            _dlg.Location = new System.Drawing.Point(Left, Top);
            _dlg.MinimumSize = new System.Drawing.Size(375, 250);
            _dlg.UseAntiAlias = true;
            // Setting up our document
            _dlg.Document = _document;
            // Show it
            _dlg.ShowDialog(this);
            // Dispose document
            _document.Dispose();

        }

        // Print handler
        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create Bitmap according form size
            Bitmap _bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            // Draw from into Bitmap DC
            this.DrawToBitmap(_bitmap, this.DisplayRectangle);
            // Draw Bitmap into Printer DC
            e.Graphics.DrawImage(_bitmap, 0, 0);
            // No longer deeded - dispose it
            _bitmap.Dispose();
        }


    }
}
