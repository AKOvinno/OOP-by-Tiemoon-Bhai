using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    internal class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public void SetFirstName(string firstName)
        {
            if (firstName.Length >= 2)
            {
                this.firstName = firstName;
            }
        }
        public string GetFirstName()
        {
            return firstName;
        }

        public void SetMiddleName(string middleName)
        {
            if (middleName.Length >= 2)
            {
                this.middleName = middleName;
            }
        }
        public string GetMiddleName(string middleName)
        {
            return middleName;
        }

        public void SetLastName(string lastName)
        {
            if (lastName.Length >= 2)
            {
                this.lastName = lastName;
            }
        }
        public string GetLastName()
        {
            return lastName;
        }

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
