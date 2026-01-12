using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough5RuntimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant reg1 = new Regular();
            reg1.GetTotalPayable();

            Participant prof1 = new Professional();
            prof1.GetTotalPayable();

            Regular regularParticipant1 = new Regular();
            Regular regularParticipant2 = new Regular();
            Professional professionalParticipant1 = new Professional();
            Regular regularParticipant3 = new Regular();
            Professional professionalParticipant2 = new Professional();
            Professional professionalParticipant3 = new Professional();

            List<Participant> participantList = new List<Participant>();
            participantList.Add(regularParticipant1);
            participantList.Add(regularParticipant2);
            participantList.Add(professionalParticipant1);
            participantList.Add(regularParticipant3);
            participantList.Add(professionalParticipant2);
            participantList.Add(professionalParticipant3);

            foreach (Participant participant in participantList)
            {
                Console.WriteLine(participant.GetTotalPayable());
            }
        }
    }
}
