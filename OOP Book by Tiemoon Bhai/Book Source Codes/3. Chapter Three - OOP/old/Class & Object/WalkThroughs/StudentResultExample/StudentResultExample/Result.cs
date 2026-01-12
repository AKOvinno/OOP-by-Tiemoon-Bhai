namespace StudentResultExample
{
    public class Result
    {
        public string studentRegNo;
        public double mathScore;
        public double physicsScore;
        public double chemistryScore;

        public double GetAverage()
        {
            return (mathScore + physicsScore + chemistryScore)/3;
        }

        public string GetGradeLetter()
        {
            double avg = GetAverage();
            if (avg >= 90)
            {
                return "A";
            }
            else if (avg >= 80)
            {
                return "B";
            }
            else if (avg >= 70)
            {
                return "C";
            }
            else if (avg >= 60)
            {
                return "D";
            }
            else if (avg >= 50)
            {
                return "E";
            }
            else
            {
                return "F";
            }
        }

    }
}
