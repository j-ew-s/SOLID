namespace SOLID.LSP
{
    public class Employee : Person
    {
        public int RegistrationNumber { get; set; }
        public int Sector { get; set; }

        public static Employee CreateEmployee( string name, string lastname, int registrationNumber, int sector)
        {
            var employee = new Employee();
            employee.Name = name;
            employee.LastName = lastname;
            employee.RegistrationNumber = registrationNumber;
            employee.Sector = sector;
            return employee;
        }

        public override bool IdentificationIsValid()
        {
            return RegistrationNumber % 2 == 0 ? true : false;
        }

        public override string GetFullName()
        {
            return Name + " " + LastName + "(" + RegistrationNumber + ")";
        }
    }
}
