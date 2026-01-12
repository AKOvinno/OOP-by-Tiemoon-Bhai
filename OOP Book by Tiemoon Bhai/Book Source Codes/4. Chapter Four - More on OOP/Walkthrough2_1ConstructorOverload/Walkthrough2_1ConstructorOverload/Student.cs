using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough2_1ConstructorOverload
{
    class Student
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string RegNo { set; get; }

        public Student()
        { 
        }

        public Student(string name, string email)
            :this()
        {
            Name = name;
            Email = email;
        }

        public Student(string name, string email, string regNo)
            :this(name, email)
        {
            RegNo = regNo;
        }
    }
}
