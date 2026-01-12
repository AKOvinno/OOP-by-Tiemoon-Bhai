using System.Collections.Generic;

namespace UniversityManagementSystem
{
    class Teacher : IBasicInformation
    {
        public string TeacherCode { set; get; }
        public string Name { set; get; }
        public string EducationalQualification { set; get; }
        public string Email { set; get; }
        public string ContactNo { set; get; }
        public string Specialization { set; get; }

        public string GetBasicInfo()
        {
            return "Name: " + Name + " " +
                   "Email: " + Email + " " +
                   "Contact No:" + ContactNo;
        }
    }
}
