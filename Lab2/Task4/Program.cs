using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"c:\xxx";
            string pathString = Path.Combine(folderName, "path");
            Directory.CreateDirectory(pathString);
            string folderName1 = @"c:\xxx\path";
            string pathString1 = Path.Combine(folderName1, "path1");
            Directory.CreateDirectory(pathString1);
            FileStream fs = new FileStream(@"c:\xxx\path\File.txt", FileMode.Create);
            fs.Close();
            string fileName = "File.txt";
            string sourcePath = @"c:\xxx\path";
            string targetPath = @"c:\xxx\path\path1";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            File.Copy(sourceFile, destFile);
            File.Delete(@"c:\xxx\path\File.txt");
        }
    }
}
