using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // declare an amount of elements in array
            string[] input = Console.ReadLine().Split(); // input element to an array using string
            int[] arr = new int[n]; // declare new array, still empty

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]); // convert chars of the string array to int array
                Console.Write(arr[i] + " " + arr[i] + " "3); // print every element twice with space between them
            }
             
        }
    }
}
