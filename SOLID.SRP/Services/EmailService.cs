using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SOLID.SRP.DataTransferObjects;
using System.Net.Mail;

namespace SOLID.SRP
{
    public static class EmailService
    {
        public static bool IsValid(string email)
        {
            return Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }

        public static void SendEmail(Email email)
        {
            var mail = new MailMessage(email.From, email.To);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = email.Subject;
            mail.Body = email.Body;
            client.Send(mail);
        }
    }
}
