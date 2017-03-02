using System.IO;

namespace SOLID.OCP
{
    public class WordFile: File
    {
        public static WordFile CreateWordFile(string name, string content)
        {
            var wordFile = new WordFile();
            wordFile.Name = name;
            wordFile.Content = content;
            return wordFile;
        }
        public override void CreateArchive(string path)
        {
            var file = new StreamWriter(path +"/"+ Name +".docx");
            file.WriteLine(Content);
            file.Close();
        }
    }
}
