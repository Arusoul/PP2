using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program {

       public static bool IsPrime(int a) // checking by funct if the numbers are prime
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


        static bool ConvertString(string s) // convert the string elements to numbers 
        {
            return IsPrime(int.Parse(s));
        }



        static void Main(string[] args)
        {
            List<string> primes = new List<string>(); // list of prime numbers, still empty

            FileStream fs = new FileStream(@"C:\Users\Аружан\Desktop\pp2\week2\Task2\input.txt.txt", FileMode.Open, FileAccess.Read); // access to read the file
            StreamReader input = new StreamReader(fs);

            string line = input.ReadLine(); 
            string[] arr = line.Split(' ');
            
            foreach (var x in arr)
            {
                if (ConvertString(x))
                {
                    primes.Add(x);
                }
            }

            input.Close();
            fs.Close();


            FileStream fs2 = new FileStream(@"C: \Users\Аружан\Desktop\pp2\week2\Task2\output.txt.txt", FileMode.Create, FileAccess.Write);
            StreamWriter output = new StreamWriter(fs2);

            foreach(var x in primes)
            {
                output.Write(x + " "); // print primes to the file
               // Console.Write(x + " ");  
            }

            
            output.Close();
            fs2.Close();
        }
    }
}
