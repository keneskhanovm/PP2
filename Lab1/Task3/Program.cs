using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] Dublicate(int[] arr)//method to dublicate given array
        {
            int[] arr2 = new int[2000]; //creating new array for result
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i * 2] = arr[i]; //first, save the original number
                arr2[i * 2 + 1] = arr[i]; //then, dublicate it next to it
            }
            return arr2;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //read input n from console
            string[] s = Console.ReadLine().Split(); //store the inputted numbers to string array, ignore the space between them
            int[] arr = new int[n]; //create integer array
            for (int i = 0; i < n; i++) arr[i] = int.Parse(s[i]); //convert the entered numbers from string to int
            int[] arr2 = Dublicate(arr); //new array to save output of Dublicate method
            for (int i = 0; i < n * 2; i++) Console.Write(arr2[i] + " "); //print the result, n*2 because the array size increases by 2
        }
    }
}
