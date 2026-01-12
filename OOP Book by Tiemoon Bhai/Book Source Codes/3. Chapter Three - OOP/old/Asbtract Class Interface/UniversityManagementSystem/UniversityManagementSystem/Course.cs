namespace UniversityManagementSystem
{
    class Course : IBasicInformation
    {
        public string CodeName { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public double Credit { set; get; }

        public string GetBasicInfo()
        {
            return "Name: " + CodeName + " " +
                   "Title: " + Title + " " +
                   "Credit: " + Credit;
        }
    }
}
