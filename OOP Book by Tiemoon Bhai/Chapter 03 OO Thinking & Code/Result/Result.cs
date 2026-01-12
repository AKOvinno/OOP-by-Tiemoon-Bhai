using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Result
{
    internal class Result
    {
        public double MathScore;
        public double PhysicsScore;
        public double ChemistryScore;

        public double AverageScore()
        {
            return (MathScore + PhysicsScore + ChemistryScore) / 3;
        }
        public string OverallGrade()
        {
            return Grade(AverageScore());
        }
        public string Grade(double mark)
        {
            if (mark > 100 || mark < 0) return "Invalid Mark";
            else if (mark <= 100 && mark >= 90) return "A+";
            else if (mark <= 89 && mark >= 80) return "B+";
            else if (mark <= 79 && mark >= 70) return "C+";
            else if (mark <= 69 && mark >= 0) return "F";
            else return "Inavlid Mark";
        }
    }
}
