using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    static class Program
    {
        static void Main()
        {
            Student aStudent = new Student();
            aStudent.Name = "Jamil";
            aStudent.Email = "j@mail.com";
            aStudent.Address = "Ghulshan 1, Dhaka";
            string info = aStudent.GetBasicInfo();

            Course aCourse = new Course();
            aCourse.CodeName = "CSE-101";
            aCourse.Title = "Computer Science Basics";
            aCourse.Credit = 3.0;
            info = aCourse.GetBasicInfo();

            Teacher aTeacher = new Teacher();
            aTeacher.Name = "Polash Chaw.";
            aTeacher.Email = "pc@mail.com";
            aTeacher.ContactNo = "0912928";
            info = aTeacher.GetBasicInfo();
        }
    }
}
