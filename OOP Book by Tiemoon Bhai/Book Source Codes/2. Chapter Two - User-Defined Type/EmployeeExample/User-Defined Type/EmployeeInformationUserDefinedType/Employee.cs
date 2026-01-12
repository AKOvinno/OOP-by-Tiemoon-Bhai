using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInformationUserDefinedType
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
