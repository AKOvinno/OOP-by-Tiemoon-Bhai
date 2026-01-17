namespace MethodReturnType_ObjectList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> stuList = GetAllStudent();
            foreach(Student stu in stuList)
            {
                Console.WriteLine(stu.Name);
                Console.WriteLine(stu.Email);
                Console.WriteLine(stu.RegNo);
                Console.WriteLine("\n");
            }
        }
        public static List<Student> GetAllStudent()
        {
            Student student1 = new Student();
            student1.Name = "Latif";
            student1.Email = "latif@gmail.com";
            student1.RegNo = "8363-736-12";
            Student student2 = new Student("Salam", "salam@gmail.com");
            Student student3 = new Student("Zamil", "zamil@gmail.com");
            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            return studentList;
        }

    }
}
