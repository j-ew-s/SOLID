namespace SOLID.LSP
{
    public class IdentityService
    {
        public static bool  ValidatePerson(Person person) {
            
            return person.IdentificationIsValid();
        }
    }
}
