using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string id;

        public Person(string firstName, string middleName, string lastName)
            :this(firstName,lastName)
        {
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName)
            :this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {
            id = "123-456";
        }

        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverseName = null;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverseName += cArray[i];
            }
            return reverseName;
        }
    }
}
