using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    internal class Employee
    {
        public Employee(string name, string email, string contactNo) : this()
        {
            Name = name;
            Email = email;
            ContactNo = contactNo;
        }
        public Employee()
        {

        }
        public string Name { set; get; }
        public string Email { set; get; }
        public string ContactNo { set; get; }
    }
}
