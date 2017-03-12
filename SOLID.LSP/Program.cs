using System;

namespace SOLID.LSP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = Customer.CreateCustomer("Gabriel", "Scavassa", Convert.ToDateTime("22/06/1997"), 12345);
            var employee = Employee.CreateEmployee("Leirbag", "Assavacs", 52100, 13);

            var customerValid = IdentityService.ValidateIDTags(customer);
            var employeeValid = IdentityService.ValidateIDTags(employee);

        }
    }
}
