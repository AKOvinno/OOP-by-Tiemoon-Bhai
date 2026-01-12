using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample2
{
    class Employee
    {
        public string id;
        public string name;
        public double salaryAmount;

        public string GetInfoAboutEmployee()
        {
            return name + " is very punctual";
        }
    }

}
