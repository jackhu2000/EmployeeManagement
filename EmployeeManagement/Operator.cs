using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class Operator
    {
        private string cs = @"server=sql6.freesqldatabase.com;port=3306;userid=sql6527607;password=t4Rtas3nkN;database=sql6527607";
        private string adminRole = "a";
        public Operator()
        {
        }
        public string getConnectionString()
        {
            return cs;
        }
        public string getAdminRole()
        {
            return adminRole;
        }
    }
}
