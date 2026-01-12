using System;

namespace ValueTypeReferenceTypeExample1
{
    public class ChangeMaker
    {
        public void Change(int b)
        {
            b = b + 10;
            Console.WriteLine(b);
        }

        public void ChangeStudent(Student aStudent)
        {
            aStudent.Name = "Pavel";
            aStudent.CGPA = 3.5;
            aStudent.AgeInYear = 21;
            Console.WriteLine(aStudent.Name + 
                " " + aStudent.CGPA + 
                " " + aStudent.AgeInYear);
        }

    }
}
