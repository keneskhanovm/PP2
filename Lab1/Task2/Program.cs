using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student //creating new class
    {
        string name; //arguments
        string id;
        string year;
        public Student(string n, string i, string y) //constructor that takes 3 arguments
        {
            name = n;
            id = i;
            year = y;
        }
        public void PrintInfo() //method for printing output
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Madiyar","18BD111169","2018"); //creating new object
            s.PrintInfo(); //calling method
        }
    }
}
