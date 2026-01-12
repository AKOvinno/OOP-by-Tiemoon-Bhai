using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough4MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Name = "OOP using C#";
            course1.Level = 2;
            course1.Fee = 20000;

            Course course2 = new Course();
            course2.Name = "Advanced Data Science using Python";
            course2.Level = 3;
            course2.Fee = 15000;

            Regular aRegularParticipant = new Regular();
            aRegularParticipant.Name = "Samima Akter";
            aRegularParticipant.PersonalContact = "021-322323";
            aRegularParticipant.Email = "s@mail.com";
            aRegularParticipant.AlternativeContactNo = "130-9737";
            aRegularParticipant.Enroll(course1);
            aRegularParticipant.Enroll(course2);

            double totalPayableAmount = aRegularParticipant.GetTotalPayable();
            Console.WriteLine(totalPayableAmount);

            Course course3 = new Course();
            course1.Name = "Networking Basics";
            course1.Level = 1;
            course1.Fee = 10000;

            Course course4 = new Course();
            course2.Name = "Java for Professionals";
            course2.Level = 2;
            course2.Fee = 20000;

            Professional aProfessionalParticipant = new Professional();
            aProfessionalParticipant.Name = "Farid Ahmed";
            aProfessionalParticipant.PersonalContact = "011-32473927";
            aProfessionalParticipant.CompanyName = "Concord Group";
            aProfessionalParticipant.CompanyContact = "02-09273648";
            aProfessionalParticipant.DiscountPercent = 10;
            aProfessionalParticipant.GetDiscountAmount();
            aProfessionalParticipant.Enroll(course1);
            aProfessionalParticipant.Enroll(course2);

            totalPayableAmount = aProfessionalParticipant.GetTotalPayable();
            Console.WriteLine(totalPayableAmount);
            Console.ReadKey();
        }
    }
}
