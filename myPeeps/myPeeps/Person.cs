using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPeeps
{
    class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected int _age;
        protected string _emailAddress;
        protected bool _isAnAdult;

        public Person(string firstName, string lastName, int age, string emailAddress)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _emailAddress = emailAddress;
            

        }

        public Person()
            {

            }

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        public bool IsAnAdult
        {
            get { return this._isAnAdult; }
            set { this._isAnAdult = value; }
        }

        public string getList()
        {

          return $"Name: {_firstName} {_lastName}\nEmail Address: {_emailAddress}\nAge: {_age}";
        }

        public static bool AreYouOldEnough(int input)
        {
            if (input >= 18)
            {
            
                return true;
            }
            else
            { 
                return false;
            }

        }
    }
}
