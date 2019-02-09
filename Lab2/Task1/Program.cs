using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool IsPal(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j]) return false;
                i++;
                j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\xxx\text1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            sr.Close();
            fs.Close();
            if (IsPal(s)) Console.Write("Yes");
            else Console.Write("No");
            Console.WriteLine();
        }
    }
}
