using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough3UpcastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 34.5;
            int valueWInRound = (int)amount;

            Participant participant1 = new Professional();
            Participant participant2 = new Regular();

            Professional participant3 = (Professional)new Participant();
            Regular participant4 = (Regular)new Participant();


            Course course1 = new Course();
            course1.Name = "C# Basics";
            course1.Level = 1;
            course1.Fee = 10000;

            Course course2 = new Course();
            course2.Name = "PHP for Professionals";
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

            Participant aParticipant = (Professional)aProfessional;
            //aParticipant.CompanyName = "Skyline";
        }
    }
}
