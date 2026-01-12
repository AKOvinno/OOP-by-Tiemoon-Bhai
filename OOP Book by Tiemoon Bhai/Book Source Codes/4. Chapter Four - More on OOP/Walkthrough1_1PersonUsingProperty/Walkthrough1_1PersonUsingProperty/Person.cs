using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1_1PersonUsingProperty
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        public string FirstName
        {
            set {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
            }
            get { return firstName; }
        }
        public string MiddleName
        {
            set {
                if (value.Length >= 2)
                {
                    middleName = value;
                }
            }
            get { return middleName; }
        }
        public string LastName
        {
            set {
                if (value.Length >= 2)
                {
                    lastName = value;
                }
            }
            get { return lastName; }
        }
        public string GetMyFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
        public string GetFullReverseName()
        {
            string fullName = GetMyFullName();
            string reverseName = "";
            for (int index = fullName.Length - 1; index >= 0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;
        }
    }
}
