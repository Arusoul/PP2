using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program {

       public 
            static bool IsPrime(int a)
        {

            bool result = true;

            if (a == 1)
            {
                result = false;
            }

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }

    
        static void Primes()
        {
           StreamReader input = new StreamReader(@"C: \Users\Аружан\Desktop\pp2\PP2\week2\Task2\input.txt");
            string[] arr = input.ReadLine().Split();

            StreamWriter output = new StreamWriter(@"C: \Users\Аружан\Desktop\pp2\PP2\week2\Task2\output.txt");
            int[] arr2 = new int[100];

            for(int i = 0; i < arr.Length; i++)
            {
                if(IsPrime(int.Parse(arr[i])) == true)
                {
                    output.Write(int.Parse(arr[i]) + " ");
                }
            }

            input.Close();
            output.Close();
        }

        static void Main(string[] args)
        {
            Primes();
        }
    }
}
