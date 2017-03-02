using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOLID.SRP.DataTransferObjects;

namespace SOLID.SRP
{
    public static class PhoneService
    {
        public static bool IsValid(string phone)
        {
            return phone.Any(char.IsLetter) ? false : true;
        }

        public static void SendTextMessage(string phone) { 
        //SOME SMS PROVIDER IMPLEMENTATION
        }
    }
}
