using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // to write an amount of an array elements using a string
            int[] array = new int[n]; // declare an array with n elements
            int[] primes = new int[n]; // declare an array which will be in the output

            int cnt = 0; // the amount of primes in the output

            string[] figures = Console.ReadLine().Split(); // write each number of the array by the string and split them

            for (int i = 0; i < n; i++) 
            {
                array[i] = int.Parse(figures[i]); // transform chars in the string array to figures with int.Parse() funct
            }

            
            for(int i = 0; i < n; i++)
            {
                for (int j = 2; j < array[i]; j++) // compare every number until it's equal to an array element
                {
                    if(array[i] % j == 0) // if there is no remainder
                    {
                        continue; // ignore not prime nums
                    }
                    
                }

                for(int i = 0; i < n; i++)
                {
                    if(array[i] > 1) // 1 isn't prime num, it starts from 2
                    {
                        primes[i] = array[i]; // give primes from the initial array to the empty new one
                        cnt++; // count that primes
                    }
                }


                Console.WriteLine(cnt); // output the amount of primes 
                for (int j = 0; j < cnt; j++)
                {
                    Console.Write(primes[j] + " "); // output the new array
                }
                
            }
        }
    }
}
