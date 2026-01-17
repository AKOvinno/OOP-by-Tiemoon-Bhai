namespace MethodReturnType_UserDefinedType
{
    internal class Program
    {
        public static Student GetStudent()
        {
            Student aStudent = new Student();
            aStudent.Name = "Ovinno";
            aStudent.Email = "ovinno@gmail.com";
            aStudent.RegNo = "8363-736-12";
            return aStudent;
        }
        static void Main(string[] args)
        {
            Student student1 = GetStudent();
            Console.WriteLine(student1.Name);
        }
    }
}
