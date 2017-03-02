using System.Collections.Generic;

namespace SOLID.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<File> files = new List<File>();
            files.Add(WordFile.CreateWordFile ( "New Word Document" , "This is a neeew document"));
            files.Add(PDFFile.CreatePDFFile("PDF_FILE", "No content, sorry."));

            FileService.Generate(files, "c:");
        }
    }
}
