using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1_1PersonAutoProperty
{
    class Person
    {
        public string FirstName { set; get; }
        public string MiddleName { set; private get; }
        public string LastName { set; get; }

        public string GetMyFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
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
