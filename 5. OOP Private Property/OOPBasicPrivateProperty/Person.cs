using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicPrivateProperty
{
    class Person
    {
        //private string firstName;
        //private string middleName;
        //private string lastName;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + MiddleName + " " + LastName; }  
        }

        //public Person(string firstName, string middleName, string lastName)
        //    : this(firstName, lastName)
        //{
        //    //SetMiddleName(middleName);
        //    MiddleName = middleName;
        //}

        //public Person(string firstName, string lastName)
        //    : this()
        //{
        //   // SetFirstName(firstName);
        //   //SetLastName(lastName);
        //    FirstName = firstName;
        //    LastName = lastName;
        //}

        //public Person()
        //{
          
        //}

        //public string FirstName
        //{
        //    get { return firstName; }
        //    set { firstName = value; }
        //}

        //public string MiddleName
        //{
        //    get { return middleName; }
        //    set { middleName = value; }
        //}

        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}

        //public string GetFullName()
        //{
        //    return GetFirstName() + " " + GetMiddleName() + " " + GetLastName();
        //}

        //public string GetFullName()
        //{
        //    return FirstName + " " + MiddleName + " " + LastName;
        //}

        public string GetReverseName()
        {
            string fullName = FullName;
            char[] cArray = fullName.ToCharArray();
            string reverseName = null;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverseName += cArray[i];
            }
            return reverseName;
        }

        //public void SetFirstName(string firstName)
        //{
        //    this.FirstName = firstName;
        //}

        //public string GetFirstName()
        //{
        //    return FirstName;
        //}


        //public void SetMiddleName(string middleName)
        //{
        //    this.MiddleName = middleName;
        //}

        //public string GetMiddleName()
        //{
        //    return MiddleName;
        //}

        //public void SetLastName(string lastName)
        //{
        //    this.LastName = lastName;
        //}

        //public string GetLastName()
        //{
        //    return LastName;
        //}
    }
}
