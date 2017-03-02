namespace SOLID.OCP
{
    public abstract class File
    {
        public  string Name { get; set; }

        public  string Content { get; set; }

        public abstract void CreateArchive(string path);
    }
}
