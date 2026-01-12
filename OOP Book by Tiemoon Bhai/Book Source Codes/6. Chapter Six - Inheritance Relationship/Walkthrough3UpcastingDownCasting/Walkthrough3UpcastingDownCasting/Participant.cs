using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough3UpcastingDownCasting
{
    public class Participant
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string PersonalContact { set; get; }
        public List<Course> EnrolledCourses { set; get; }

        public Participant()
        {
            EnrolledCourses = new List<Course>();
        }

        public void Enroll(Course aCourse)
        {
            EnrolledCourses.Add(aCourse);
        }

        public virtual double GetTotalPayable()
        {
            double total = 0;
            foreach (Course aCourse in EnrolledCourses)
            {
                total += aCourse.Fee;
            }
            return total;
        }
    }
}
