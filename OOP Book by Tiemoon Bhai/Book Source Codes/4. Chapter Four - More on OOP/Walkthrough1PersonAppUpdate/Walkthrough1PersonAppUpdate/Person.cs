using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1PersonAppUpdate
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public string GetMyFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetMiddleName(string middleName)
        {
            this.middleName = middleName;
        }

        public string GetMiddleName()
        {
            return middleName ;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetFirstName(string firstName)
        {
            if (firstName.Length >= 2)
            {
                this.firstName = firstName;
            }
        }

        //public void SetLastName(string lastName)
        //{
        //    if (lastName.Length >= 2)
        //    {
        //        this.lastName = lastName;
        //    }
        //    else
        //    {
        //        throw new Exception("Last name must be minimum two-character long.");
        //    }
        //}

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
