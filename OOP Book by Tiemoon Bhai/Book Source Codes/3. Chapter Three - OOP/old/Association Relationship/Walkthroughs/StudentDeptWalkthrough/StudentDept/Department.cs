using System.Collections.Generic;
using System.Drawing;

namespace StudentDept
{
    public class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public List<Student> StudentList { set; get; }
        public Department(string code, string name) : this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
            StudentList = new List<Student>();
        }
    }
}