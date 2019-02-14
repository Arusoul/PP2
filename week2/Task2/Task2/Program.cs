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

            if (a == 1) result = false;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }


        static bool PrimeString(string s)
        {
            return IsPrime(int.Parse(s));
        }



        static void Main(string[] args)
        {
            List<string> primes = new List<string>();

            FileStream fs = new FileStream(@"C:\Users\Аружан\Desktop\pp2\week2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader input = new StreamReader(fs);

            string line = input.ReadLine();
            string[] arr = line.Split(' ');
            
            foreach (var x in arr)
            {
                if (PrimeString(x))
                {
                    primes.Add(x);
                }
            }

            input.Close();
            fs.Close();


            FileStream fs2 = new FileStream(@"C: \Users\Аружан\Desktop\pp2\week2\Task2\output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter output = new StreamWriter(fs2);

            foreach(var x in primes)
            {
                output.Write(x + " ");
                Console.Write(x + " ");
            }

            
            output.Close();
            fs2.Close();
        }
    }
}
