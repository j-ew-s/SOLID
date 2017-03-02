﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.SRP.DataTransferObjects
{
    public class Email
    {
        public string  From     { get; private set; }
        public string  To       { get; private set; }
        public string  Subject  { get; private set; }
        public string  Body     { get; private set; }

        public static Email CreateEmail(string from, string to, string subject, string body)
        {
            var email = new Email();
            email.To = to;
            email.From = from;
            email.Subject = subject;
            email.Body = body;
            return email;
        }

        public static bool IsValid(Email email)
        {
            return  SubjectIsValid(email.Subject) &&
                    BodyIsValid(email.Body) &&
                    EmailService.IsValid(email.From) &&
                    EmailService.IsValid(email.To);
        }

        public static bool SubjectIsValid(string subject) { 
            return !string.IsNullOrEmpty(subject);
        }

        public static bool BodyIsValid(string body)
        {
            return !string.IsNullOrEmpty(body);
        }
    }
}
