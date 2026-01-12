using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    internal class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetMyFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
        public string GetFullReverseName()
        {
            string fullName = GetMyFullName();
            string reverseName = "";
            for(int index = fullName.Length - 1; index >= 0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;
        }
    }
}
