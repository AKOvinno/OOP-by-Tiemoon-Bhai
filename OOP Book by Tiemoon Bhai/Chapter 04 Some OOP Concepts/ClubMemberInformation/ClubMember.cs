using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClubMemberInformation
{
    internal class ClubMember
    {
        public ClubMember(string name, string contactNo, string hasPaidMembershipFee, string membershipType) : this()
        {
            Name = name;
            ContactNo = contactNo;
            HasPaidMembershipFee = hasPaidMembershipFee;
            MembershipType = membershipType;

        }
        public ClubMember()
        {

        }
        public string Name { set; get; }
        public string ContactNo { set; get; }
        public string HasPaidMembershipFee { set; get; }
        public string MembershipType { set; get; }
    }
}
