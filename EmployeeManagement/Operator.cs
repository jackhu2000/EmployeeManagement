using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EmployeeManagement
{
    public class Operator
    {
        private string cs = @"server=hrs.mysql.database.azure.com;port=3306;userid=group4;password=Server123;database=hrs";
        public Operator()
        {
        }
        public string getConnectionString()
        {   
            return cs;
        }
    }
}
