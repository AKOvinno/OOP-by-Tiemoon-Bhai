using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough2TrainingInstitute
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant participant1 = new Professional();
            Participant participant2 = new Regular();

            Professional participant3 = (Professional)new Participant();
            Regular participant4 = (Regular)new Participant();


            Course course1 = new Course();
            course1.Name = "OOP using C#";
            course1.Level = 2;
            course1.Fee = 20000;

            Course course2 = new Course();
            course2.Name = "Advanced Data Science using Python";
            course2.Level = 3;
            course2.Fee = 20000;

            Professional aProfessional = new Professional();
            aProfessional.Name = "Farid Ahmed";
            aProfessional.PersonalContact = "011-32473927";
            aProfessional.CompanyName = "Concord Group";
            aProfessional.CompanyContact = "02-09273648";
            aProfessional.DiscountPercent = 5;
            aProfessional.GetDiscountAmount();
            aProfessional.Enroll(course1);
            aProfessional.Enroll(course2);

            //Participant aParticipant = aProfessional;
            //Professional professional2 = (Professional)aParticipant; 
        }
    }
}
