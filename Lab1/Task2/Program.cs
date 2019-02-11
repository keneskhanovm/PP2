using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        string name;
        string id;
        string year;
        public Student(string n, string i, string y)
        {
            name = n;
            id = i;
            year = y;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Madiyar","18BD111169","2018");
            s.PrintInfo();
        }
    }
}
