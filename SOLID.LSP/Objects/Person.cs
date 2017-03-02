namespace SOLID.LSP
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public abstract bool IdentificationIsValid();

        public abstract string GetFullName();

    }
}
