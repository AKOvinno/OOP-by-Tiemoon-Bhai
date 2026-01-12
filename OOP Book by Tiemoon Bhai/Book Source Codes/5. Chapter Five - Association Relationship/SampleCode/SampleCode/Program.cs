using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            Result myResult = new Result();
            aStudent.ResultSheet = myResult;
            Result aResult = aStudent.ResultSheet;
        }

        public Student GetStudent()
        {
            Student aStudent = new Student();
            aStudent.Name = "Latif";
            aStudent.Email = "latif@mailbd.com";
            aStudent.RegNo = "8363-736-12";
            return aStudent;
        }

        public List<Student> GetAllStudent()
        {
            Student student1 = new Student();
            student1.Name = "Latif";
            student1.Email = "latif@mailbd.com";
            student1.RegNo = "8363-736-12";
            Student student2 = new Student("Salam", "s@mail.com");
            Student student3 = new Student("Zamil", "z@mail.com");
            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);

            return studentList;
        }

        public void Save(Student aStudent)
        { 

        }

    }
}
