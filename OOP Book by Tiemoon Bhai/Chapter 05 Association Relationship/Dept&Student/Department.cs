using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dept_Student
{
    internal class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }

        public List<Student> StudentList;

        public Department()
        {
            StudentList = new List<Student>();
        }
        public Department(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
