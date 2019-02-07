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

            string[] figures = Console.ReadLine().Split(new char[] { ' ' }); // write each number of the array by the string and split them with an array of chars

            for (int i = 0; i < figures.Length; i++)
            {
                array[i] = int.Parse(figures[i]); // transform chars in the string array to figures with int.Parse() funct
            }

            int cnt = 0;

            int[] primes = new int[100];
            
            for(int i = 0; i < array.Length; i++)
            {
                
                for(int j = 2; j <= array[i]; j++)
                {
                    if(array[i] % j == 0)
                    {
                        continue;
                    }
                    else if(array[i] == 2)
                    {
                        cnt++;
                        array[i] = primes[i];
                    }
                    else
                    {
                        cnt++;
                        array[i] = primes[i];
                    }
                }


                Console.WriteLine(cnt);
                for (int j = 0; j < cnt; j++)
                {
                    Console.Write(primes[j] + ' ');
                }
                
            }
        }
    }
}
