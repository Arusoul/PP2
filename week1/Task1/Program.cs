using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool IsPrime (int a) // create a funct to find out is a number prime or not
        {
            bool check = true;

            if(a = 1)
            {
                check = false;
            }

            for(int i = 2; i < a; i++) // check if the number is divisible by num before (n - 1)
            {
                if(a % i == 0)
                {
                    check = false;
                }
            }

            return check;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // to write an amount of an array elements using a string
            int[] array = new int[n]; // declare an array with n elements

            int[] primes = new int[n]; // declare an array which will be in the output

            string[] figures = Console.ReadLine().Split(); // write each number of the array by the string and split them

            int cnt = 0; // the amount of primes in the output

            for (int i = 0; i < n; i++) 
            {
                array[i] = int.Parse(figures[i]); // transform chars in the string array to figures with int.Parse() funct
            }

            for(int i = 0; i < n; i++)
            {
                if(IsPrime(array[i]) == true)
                {
                    array[i] = primes[i];
                    cnt++;
                }
            }

                Console.Write(cnt); // output the amount of primes 
                Console.Write(System.Environment.NewLine); // new line

                for (int j = 0; j < cnt; j++) // output primes with spaces
                 {
                    Console.Write(primes[j]);
                    Console.Write(" ");
                 }
            }
        }
    }
