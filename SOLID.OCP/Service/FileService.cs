using System.Collections.Generic;

namespace SOLID.OCP
{
    public static class FileService
    {
        public static void Generate(IList<File> files, string path)
        {
            foreach (var file in files)
            {
                file.CreateArchive(path);
            }
        }
    }
}
