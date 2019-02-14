using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime(int a) // create a function to find if the number is prime
        {
            bool ch = true;
            if (a == 1) ch = false;
            for(int i = 2; i < a; i++) // the checking cycle for every number is it divisible by numer -1
            {
                if(a % i == 0)
                {
                    ch = false;
                } 
            }
            return ch; // return the result false or true
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // to write an amount of an array elements using a string

            string s = Console.ReadLine();
            string[] figures = s.Split(); // write each number of the array by the string and split them

            int cnt = 0; // the amount of primes in the output

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(figures[i]); // transform an element of the array to figure
                if (Prime(c) == true) cnt++; // checking numbers
            }

        Console.WriteLine(cnt); // output of the amount of primes
            
           for(int i = 0; i < n; i++)
            {
                int c = int.Parse(figures[i]);
                if(Prime(c) == true)
                {
                    Console.WriteLine(c + " "); // output of primes with spaces
                }
            }
                      
            }
        }
 }
