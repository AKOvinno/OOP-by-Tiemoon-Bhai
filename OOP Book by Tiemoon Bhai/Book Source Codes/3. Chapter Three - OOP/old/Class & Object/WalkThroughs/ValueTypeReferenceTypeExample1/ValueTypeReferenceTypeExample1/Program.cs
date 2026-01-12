using System;

namespace ValueTypeReferenceTypeExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 100;
            int q = p;
            p = 300;

            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.ReadKey();

            Console.WriteLine("------------");

            Student st1 = new Student();
            st1.Name = "Zabed";
            st1.CGPA = 3.45;
            st1.AgeInYear = 23;

            Student st2 = st1;

            st2.Name = "Jamil";
            st2.CGPA = 3.75;
            st2.AgeInYear = 24;

            Console.WriteLine(st1.Name);
            Console.WriteLine(st1.CGPA);
            Console.WriteLine(st1.AgeInYear);
            Console.WriteLine("---");
            Console.WriteLine(st2.Name);
            Console.WriteLine(st2.CGPA);
            Console.WriteLine(st2.AgeInYear);
            Console.ReadKey();










            int a = 10;
            ChangeMaker aChangeMaker = new ChangeMaker();
            aChangeMaker.Change(a);
            Console.WriteLine(a);
            Console.ReadKey();

            Student stu1 = new Student();
            stu1.Name = "Hasan";
            stu1.CGPA = 3.77;
            stu1.AgeInYear = 23;
            aChangeMaker.ChangeStudent(stu1);
            Console.WriteLine(stu1.Name +
            " " + stu1.CGPA +
            " " + stu1.AgeInYear);




        }
    }
}
