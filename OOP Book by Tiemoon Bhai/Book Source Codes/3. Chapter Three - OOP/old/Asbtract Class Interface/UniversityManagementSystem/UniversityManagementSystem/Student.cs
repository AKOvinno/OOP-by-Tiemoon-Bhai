namespace UniversityManagementSystem
{
    class Student : IBasicInformation
    {
        public string RegNo { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }

        public string GetBasicInfo()
        {
            return "Name: " + Name + " " +
                   "EMail: " + Email + " " +
                   "Address: " + Address;
        }
    }
}
