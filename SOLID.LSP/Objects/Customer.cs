using System;

namespace SOLID.LSP
{
    public class Customer : Person
    {
        public DateTime Birth { get; set; }
        public int FidelityCard { get; set; }

        public static Customer CreateCustomer( string name, string lastname, DateTime birth, int fidelityCard)
        {
            var customer = new Customer();
            customer.Name = name;
            customer.LastName = lastname;
            customer.Birth = birth;
            customer.FidelityCard = fidelityCard;
            return customer;
        }

        public override bool IdentificationIsValid()
        {
            return FidelityCard % 2 == 0 ? false : true;
        }

        public override string GetFullName()
        {
            return Name + " " + LastName;
        }
    }
}
