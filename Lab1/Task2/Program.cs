using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Student()
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.PrintInfo();
        }
    }

}
