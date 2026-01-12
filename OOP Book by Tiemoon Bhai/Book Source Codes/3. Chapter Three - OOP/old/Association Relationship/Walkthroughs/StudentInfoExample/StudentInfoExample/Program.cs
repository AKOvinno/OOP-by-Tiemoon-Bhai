using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FirstName = "Bapon";
            student1.LastName = "Chowdhary";
            student1.RegNo = "930-0389-39";

            ContactInfo stu1ContactInfo = new ContactInfo();
            stu1ContactInfo.Email = "bach@mail.com";
            stu1ContactInfo.MobileNo = "08971323";
            stu1ContactInfo.PostalAddress = "Kuril, Dhaka";

            student1.ContactInfo = stu1ContactInfo;

            Student student2 = new Student();
            student2.FirstName = "Neelima";
            student2.LastName = "Ibrahim";
            student2.RegNo = "826-2927-29";

            ContactInfo stu2ContactInfo = new ContactInfo();
            stu2ContactInfo.Email = "neel@mail.com";
            stu2ContactInfo.MobileNo = "06282512";
            stu2ContactInfo.PostalAddress = "Dhanmondi, Dhaka";

            student2.ContactInfo = stu2ContactInfo;

            Console.WriteLine(student1.FirstName + " " + 
                stu1ContactInfo.MobileNo + " " + 
                stu1ContactInfo.Email);
            Console.WriteLine(student2.FirstName + " " +
                stu2ContactInfo.MobileNo + " " +
                stu2ContactInfo.Email);
            Console.ReadKey();

        }
    }
}
