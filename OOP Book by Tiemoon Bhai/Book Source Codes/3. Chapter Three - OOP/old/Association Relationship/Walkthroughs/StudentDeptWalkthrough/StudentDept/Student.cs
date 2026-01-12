namespace StudentDept
{
    public class Student
    {
        private string RegNo { set; get; }
        private string Name { set; get; }
        private string Email { set; get; }

        public Student(string regNo, string name, string email)
        {
            RegNo = regNo;
            Name = name;
            Email = email;
        }

    }
}