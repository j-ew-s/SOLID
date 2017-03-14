using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.SRP
{
    public class Person
    {
        public int      Id       { get; private set; }
        public string   Name     { get; private set; }
        public string   LastName { get; private set; }
        public DateTime Birth    { get; private set; }
        public string   Email    { get; private set; }
        public string   Phone    { get; private set; }

        Person(){  }

        public static Person CreatePerson(string name, string lastName, DateTime birth, string email, string phone)
        {
            var person = new Person();
            person.Name = name;
            person.LastName = lastName;
            person.Birth = birth;
            person.Email = email;
            person.Phone = phone;
            return person;
        }

        public bool IsValid()
        {
            return SOLID.SRP.DataTransferObjects.Email.IsPropertyEmailValid(Email) &&
                BirthIsValid() && 
                NameIsValid() && 
                LastNameIsValid() && 
                PhoneService.IsValid(Phone);
        }

        bool BirthIsValid() { 
            return Birth != new DateTime();
        }

        bool NameIsValid() {
            return !string.IsNullOrEmpty(Name);
        }

        bool LastNameIsValid() {
            return !string.IsNullOrEmpty(LastName);
        }

        public string GetFullName()
        {
            return Name+" "+LastName;
        }
    }
}
