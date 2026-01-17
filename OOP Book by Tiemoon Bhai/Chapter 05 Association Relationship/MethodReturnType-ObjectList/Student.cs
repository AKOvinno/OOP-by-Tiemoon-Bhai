using System;
using System.Collections.Generic;
using System.Text;

namespace MethodReturnType_ObjectList
{
    internal class Student
    {
        public Student(string Name, string Email, string RegNo)
        {
            this.Name = Name;
            this.Email = Email;
            this.RegNo = RegNo;
        }
        public Student(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }
        public Student()
        {

        }
        public string Name { set; get; }
        public string Email { set; get; }
        public string RegNo { set; get; }
    }
}
