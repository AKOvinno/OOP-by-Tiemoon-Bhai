using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough2_1ConstructorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Rana", "r@mail.com");
            Student student3 = new Student("Imtiaz", "im@mail.com", "091-018");
        }
    }
}
