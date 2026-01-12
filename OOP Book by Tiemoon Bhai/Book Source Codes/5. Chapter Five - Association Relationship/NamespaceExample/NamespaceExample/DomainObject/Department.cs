using NamespaceExample;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample.DomainObject
{
    public class Department
    {
        public List<Student> Students { set; get; }
        public List<Course> Courses { set; get; }
        public List<Enrollment> Enrollments { set; get; }

        public Department()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Enrollments = new List<Enrollment>();
        }
    }
}
