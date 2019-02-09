using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Tree(string path, int x)
        {
            DirectoryInfo d = new DirectoryInfo(@path);
            FileSystemInfo[] fsi = d.GetFileSystemInfos();
            string s = new string(' ', x);
            for (int i=0; i<fsi.Length; i++)
            {
                FileSystemInfo fs = fsi[i];
                Console.WriteLine(s + fs.Name);
                if (fs.GetType() == typeof(DirectoryInfo)) Tree(fs.FullName, x + 4);
            }
        }

        static void Main(string[] args)
        {
            string s = @"C:\Users\kenes\Desktop\C#";
            Tree(s, 0);
            Console.ReadKey();
        }
    }
}
