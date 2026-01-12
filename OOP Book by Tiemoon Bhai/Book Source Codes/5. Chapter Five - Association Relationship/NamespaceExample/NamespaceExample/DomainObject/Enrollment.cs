using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample.DomainObject
{
    public class Enrollment
    {
        public Student Student { set; get; }
        public Course Course { set; get; }
        public DateTime EnrollmentDate { set; get; }
    }
}
