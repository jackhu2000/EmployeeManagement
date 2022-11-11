using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class SeleEmpForm : Form
    {
        String aln = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        String n = "0123456789";
        String al = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String fr = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 _-";
        String pn = " 0123456789-";
        String en = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 _.@-";
        String un= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 _.@/:-%&=,";
        private bool bfi;
        private bool bla;
        private bool baddr1;
        private bool baddr2;
        private bool bcity;
        private bool bde;
        private bool bsa;
        private bool btl;
        private bool bul;
        private bool bgr;
        private bool bem;
        private bool bph;
        private bool bim;
        private bool bemd;
        private bool bdob;
        private bool init = true;
        private User user;
        private Dictionary<String, String> userdict;
        private Dictionary<String,String> chDic = new Dictionary<String,String>();
        public SeleEmpForm()
        {
            InitializeComponent();
        }

        public SeleEmpForm(String username)
        {
            init=true;
            String sql = String.Format("SELECT * FROM hrs.account WHERE username='{0}';", username);
            InitializeComponent();
            user = new User(username);
            if (user.get_isInit())
            {
                bfi = true;
                bla = true;
                baddr1= true;
                baddr2= true;
                bcity= true;
                bde= true;
                bsa= true;
                btl= true;
                bul= true;
                bgr= true;
                bem= true;
                bph= true;
                bim= true;
                bemd= true;
                bdob= true;
                userdict = user.getInfo();
                firstname.Text = userdict["FirstName"];
                lastname.Text = userdict["LastName"];
                addr1.Text = userdict["AddressLine1"];
                addr2.Text = userdict["AddressLine2"];
                city.Text = userdict["City"];
                department.Text = userdict["Department"];
                salary.Text = userdict["Salary"];
                totalleaves.Text = userdict["TotalLeave"];
                usedleaves.Text = userdict["UsedLeaves"];
                grade.Text = userdict["Grade"];
                email.Text = userdict["email"];
                phone.Text = userdict["Phone"];
                img.Text = userdict["imgUrl"];
                if(userdict["imgUrl"] != "")
                {
                    pic.ImageLocation = @userdict["imgUrl"];
                }
                String emd = userdict["EmploymentStartDate"];
                String dob = userdict["DoB"];
                String[] emds = emd.Split("/");
                String[] dobs = dob.Split("/");
                if (dobs.Length == 3)
                {
                    dd.Text = dobs[0];
                    dm.Text = dobs[1];
                    dy.Text = dobs[2];
                }
                if (emds.Length == 3)
                {
                    ed.Text = emds[0];
                    em.Text = emds[1];
                    ey.Text = emds[2];
                }
                if (userdict["isAdmin"] == "True")
                    isAdmin.Checked = true;
                else
                    isAdmin.Checked = false;
                init = false;
            }
            

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Operator ope = new Operator();
            if (bfi&&bla&&baddr1&&baddr2&&bcity&&bde&&bsa&&btl&&bul&&bgr&&bem&&bph&&bim&&bemd&&bdob)
            {
                bool uploadRes = user.updateInfo(chDic, userdict["username"]);
                if (uploadRes)
                {
                    ope.displayMessageBox("Update Success !");
                    chDic = new Dictionary<string, string>();
                    bfi = true;
                    bla = true;
                    baddr1 = true;
                    baddr2 = true;
                    bcity = true;
                    bde = true;
                    bsa = true;
                    btl = true;
                    bul = true;
                    bgr = true;
                    bem = true;
                    bph = true;
                    bim = true;
                    bemd = true;
                    bdob = true;
                }
                else
                {                 
                    ope.displayMessageBox("Update Failed !");
                }
            }
        }

        private void SeleEmpForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            
            foreach(char i in firstname.Text)
            {
                if (!al.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in FirstName", i);
                    bfi = false;
                    return;
                }
            }
            if (!chDic.ContainsKey("FirstName"))
            {
                chDic.Add("FirstName", "");
            }
            chDic["FirstName"]=firstname.Text;
            msg.Text = "";
            bfi = true;
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in lastname.Text)
            {
                if (!al.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in LastName", i);
                    bla = false;
                    return;
                }
            }
            if (!chDic.ContainsKey("LastName"))
            {
                chDic.Add("LastName", "");
            }
            chDic["LastName"] = lastname.Text;
            msg.Text = "";
            bla = true;
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;

            if (!float.TryParse(salary.Text,out _))
            { msg.Text = String.Format("Invaild Salary");bsa = false; return; }
            if (!chDic.ContainsKey("Salary"))
            {
                chDic.Add("Salary", "");
            }
            chDic["Salary"] = salary.Text;
            msg.Text = "";
            bsa = true;
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in phone.Text)
            {
                if (!pn.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in Phone", i);
                    bph = false;
                    return;
                }
            }
            if (!chDic.ContainsKey("Phone"))
            {
                chDic.Add("Phone", "");
            }
            chDic["Phone"] = phone.Text;
            msg.Text = "";
            bph = true;
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in city.Text)
            {
                if (!fr.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in City", i);
                    bcity = false;
                    return;
                }
            }
            if (!chDic.ContainsKey("City"))
            {
                chDic.Add("City", "");
            }
            chDic["City"] = city.Text;
            msg.Text = "";
            bcity = true;
        }

        private void grade_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(grade.Text,out int _))
            {
                msg.Text = "Invaild Grade";
                bgr = false;
                return;
            }
            if (!chDic.ContainsKey("Grade"))
            {
                chDic.Add("Grade", "");
            }
            chDic["Grade"] = grade.Text;
            msg.Text = "";
            bgr = true;
        }

        private void totalleaves_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(totalleaves.Text, out int _))
            {
                msg.Text = "Invaild TotalLeave";
                btl= false;
                return;
            }
            if (!chDic.ContainsKey("TotalLeave"))
            {
                chDic.Add("TotalLeave", "");
            }
            chDic["TotalLeave"] = totalleaves.Text;
            msg.Text = "";
            btl = true;
        }

        private void usedleaves_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(usedleaves.Text, out int _))
            {
                msg.Text = "Invaild UsedLeaves";
                bul = false;
                return;
            }
            if (!chDic.ContainsKey("UsedLeaves"))
            {
                chDic.Add("UsedLeaves", "");
            }
            chDic["UsedLeaves"] = usedleaves.Text;
            msg.Text = "";
            bul = true;
        }

        private void department_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in department.Text)
            {
                if (!fr.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in Department", i);
                    bde = false;
                    return;
                }
            }
            if (!chDic.ContainsKey("Department"))
            {
                chDic.Add("Department", "");
            }
            chDic["Department"] = department.Text;
            msg.Text = "";
            bde = true;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in email.Text)
            {
                if (!en.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in email", i);
                    bem = false;
                    return;
                }
            }
            if (!chDic.ContainsKey("email"))
            {
                chDic.Add("email", "");
            }
            chDic["email"] = email.Text;
            msg.Text = "";
            bem = true;
        }

        private void addr1_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in addr1.Text)
            {
                if (!fr.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in addr1", i);
                    baddr1= false;
                    return;
                }
            }
            if (!chDic.ContainsKey("AddressLine1"))
            {
                chDic.Add("AddressLine1", "");
            }
            chDic["AddressLine1"] = addr1.Text;
            msg.Text = "";
            baddr1= true;
        }

        private void addr2_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in addr2.Text)
            {
                if (!fr.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in addr2", i);
                    baddr2= false;
                    return;
                }
            }
            if (!chDic.ContainsKey("AddressLine2"))
            {
                chDic.Add("AddressLine2", "");
            }
            chDic["AddressLine2"] = addr2.Text;
            msg.Text = "";
            baddr2= true;
        }

        private void dd_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(dd.Text, out int _))
            {
                msg.Text = "Invaild DoB";
                bdob=false;
                return;
            }
            if (!chDic.ContainsKey("DoB"))
            {
                chDic.Add("DoB", "");
            }
            chDic["DoB"] = String.Format("{0:d2}/{1:d2}/{2:d4}", int.Parse(dd.Text), int.Parse(dm.Text), int.Parse(dy.Text));
            msg.Text = "";
            bdob = true;
        }

        private void dm_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(dm.Text, out int _))
            {
                msg.Text = "Invaild DoB";
                bdob=false;
                return;
            }
            if (!chDic.ContainsKey("DoB"))
            {
                chDic.Add("DoB", "");
            }
            chDic["DoB"] = String.Format("{0:d2}/{1:d2}/{2:d4}", int.Parse(dd.Text), int.Parse(dm.Text), int.Parse(dy.Text));
            msg.Text = "";
            bdob = true;
        }

        private void dy_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(dy.Text, out int v))
            {
                msg.Text = "Invaild DoB";
                bdob=false;
                return;
            }
            if (!chDic.ContainsKey("DoB"))
            {
                chDic.Add("DoB", "");
            }
            chDic["DoB"] = String.Format("{0:d2}/{1:d2}/{2:d4}", int.Parse(dd.Text), int.Parse(dm.Text), int.Parse(dy.Text));
            msg.Text = "";
            bdob = true;
        }

        private void ed_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(ed.Text, out int _))
            {
                msg.Text = "Invaild EmploymentStartDate";
                bemd=false;
                return;
            }
            if (!chDic.ContainsKey("EmploymentStartDate"))
            {
                chDic.Add("EmploymentStartDate", "");
            }
            chDic["EmploymentStartDate"] = String.Format("{0:d2}/{1:d2}/{2:d4}", int.Parse(ed.Text), int.Parse(em.Text), int.Parse(ey.Text));
            msg.Text = "";
            bemd = true;
        }

        private void em_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(em.Text, out int _))
            {
                msg.Text = "Invaild EmploymentStartDate";
                bemd=false;
                return;
            }
            if (!chDic.ContainsKey("EmploymentStartDate"))
            {
                chDic.Add("EmploymentStartDate", "");
            }
            chDic["EmploymentStartDate"] = String.Format("{0:d2}/{1:d2}/{2:d4}", int.Parse(ed.Text), int.Parse(em.Text), int.Parse(ey.Text));
            msg.Text = "";
            bemd = true;
        }

        private void ey_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!int.TryParse(ey.Text, out int _))
            {
                msg.Text = "Invaild EmploymentStartDate";
                bemd=false;
                return;
            }
            if (!chDic.ContainsKey("EmploymentStartDate"))
            {
                chDic.Add("EmploymentStartDate", "");
            }
            chDic["EmploymentStartDate"] = String.Format("{0:d2}/{1:d2}/{2:d4}", int.Parse(ed.Text), int.Parse(em.Text), int.Parse(ey.Text));
            msg.Text = "";
            bemd = true;
        }

        private void isAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            if (!chDic.ContainsKey("isAdmin"))
            {
                chDic.Add("isAdmin", "");
                chDic.Add("Role", "");
            }
            if (isAdmin.Checked)
            {              
                chDic["isAdmin"] = "1";
                chDic["Role"] = "Admin";

            }
            else
            {
                chDic["isAdmin"] = "0";
                chDic["Role"] = "Employee";
            }
        }

        private void img_TextChanged(object sender, EventArgs e)
        {
            if (init)
                return;
            foreach (char i in img.Text)
            {
                if (!un.Contains(i))
                {
                    msg.Text = String.Format("Invaild char {0} in imgUri", i);
                    bim=false;
                    return;
                }
            }
            try
            {
                pic.ImageLocation = @img.Text;
            }
            catch
            {
                msg.Text = "Invaild image uri";
                return;
            }
            if (!chDic.ContainsKey("imgUrl"))
            {
                chDic.Add("imgUrl", "");
            }
            chDic["imgUrl"] = img.Text;
            msg.Text = "";
            bim=true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //TODO: TURN TO ADMINFORM WHEN ADMINFORM DONE.
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
