using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Student
    {
        public Student()
        { 
        }

        public Result ResultSheet { set; get; }
        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public string Name { set; get; }
        public string Email { set; get; }
        public string RegNo { set; get; }
    }
}
