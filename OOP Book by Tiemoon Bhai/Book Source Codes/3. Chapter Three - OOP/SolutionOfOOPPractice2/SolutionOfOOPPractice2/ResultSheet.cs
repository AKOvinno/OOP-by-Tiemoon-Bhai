using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfOOPPractice2
{
    class ResultSheet
    {
        public double mathScore;
        public double physicsScore;
        public double chemistryScore;

        public string GetOverAllGradeLetter()
        {
            double avgScore = GetAverageScore();
            return GetGradeLetter(avgScore);
        }

        public double GetAverageScore()
        {
            return (mathScore + physicsScore + chemistryScore)/3 ;
        }

        public string GetMathGrade()
        {
            return GetGradeLetter(mathScore);
        }

        public string GetPhysicsGrade()
        {
            return GetGradeLetter(physicsScore);
        }
        public string GetChemistryGrade()
        {
            return GetGradeLetter(chemistryScore);
        }

        private string GetGradeLetter(double score)
        {
            if (score <= 100 && score >= 90)
            {
                return "A+";
            }
            else if (score < 90 && score >= 80)
            {
                return "B+";
            }
            else if (score < 80 && score >= 70)
            {
                return "C+";
            }
            else
            {
                return "F";
            }        
        }
    }
}
