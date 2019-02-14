using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool IsPrime(int n) //check the number is it prime or not
        {
            if (n < 2) return false; //prime numbers starts with 2
            for (int i = 2; i * i <= n; i++) //loop to find out have the number dividers other than 1 and this number itself
            {
                if (n % i == 0) return false; //if number divides by 2,3,.. and etc, then it wouldn't be prime
            }
            return true; //if number will not fail these tests, then it is prime
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //to read numbers entered from console
            string[] s = Console.ReadLine().Split(); //to save the entered numbers into array, split - to ignore space(bar) between them
            int[] arr = new int[100000]; //array of integers for prime numbers
            int cnt = 0; //amount of prime numbers
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]); //convert the numbers in array to integer
                if (IsPrime(x)) arr[cnt++] = x; //if it is prime(calling IsPrime method) then array(for prime n) store this number and size of array increases
            }
            Console.WriteLine(cnt); //output amount of prime numbers
            for (int i = 0; i < cnt; i++) Console.Write(arr[i] + " "); //output prime numbers with space between them
            Console.ReadKey();
        }
    }
}

