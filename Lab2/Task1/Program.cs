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
        int cnt = 0;
        static int IsPal(string s, , int i, int n)
        {
            if (n < 0) return cnt;
            if (s[i] = !s[n]) return cnt;
            else
            {
                i++;
                n--;
                cnt++;
                return IsPal(string s);
            }
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\xxx\text1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            sr.Close();
            fs.Close();
            if 
            Console.Write("Yes");
        }
    }
}
