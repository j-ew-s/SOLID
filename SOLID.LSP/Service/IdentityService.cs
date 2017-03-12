namespace SOLID.LSP
{
    public class IdentityService
    {
        public static bool  ValidateIDTags(Person person) {
            // DO SOME OTHER TREATMENTS.
            //...
            return person.IdentificationIsValid();
        }
    }
}
