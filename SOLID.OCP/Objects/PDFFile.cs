using System.IO;

namespace SOLID.OCP
{
    public class PDFFile : File
    {
        public static PDFFile CreatePDFFile(string name, string content)
        {
            var pdfFile = new PDFFile();
            pdfFile.Name = name;
            pdfFile.Content = content;
            return pdfFile;
        }

        public override void CreateArchive(string path)
        {
            //DO SOME PDF SPECIFICATION
            var file = new StreamWriter(path + "/" + Name + ".pdf");
            file.WriteLine(Content);
            file.Close();
        }
    }
}
