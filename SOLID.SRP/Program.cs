using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOLID.SRP.DataTransferObjects;
using SOLID.SRP.Repository;

namespace SOLID.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Person();
            var person = Person.CreatePerson("Gabriel", "Scavassa", Convert.ToDateTime("22/06/1987"), "gabriel.scavassa@outlook.com", "14997774426");
            if (!person.IsValid())
            {
                Console.WriteLine("This person has some invalid attributes");
                //Do some thing
            }

            PersonRepository.InsertPerson(person);

            var body = string.Format("Hi,{0}! Your subscription is completed. Now you can have our weekly news!", person.GetFullName());

            var email = Email.CreateEmail("no-reply@srp.com", person.Email, "Subscription to SRP princle articles.", body);

            EmailService.SendEmail(email);
            Console.WriteLine("The email has been sent!");
            
        }
    }
}
