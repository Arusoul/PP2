using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{

    class Program
    {
        public static void palindrome()
        {
            FileStream fs = new FileStream(@"C:\Users\Аружан\Desktop\pp2\week2\Task1\input.txt.txt", FileMode.Open, FileAccess.Read); // the way to get the file text
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadLine(); // read the text from the file

            int count = 0;

            for(int i = 0; i < text.Length / 2; i++)
            {
                if(text[i] != text[text.Length - 1 - i]) // checking if the string is palindrome
                {
                    count++;
                    break;
                }
            }

            if (count >= 1) Console.WriteLine("No");

            else Console.WriteLine("Yes");

            sr.Close();
        }

        static void Main(string[] args)
        {
            palindrome(); // call the function

            Console.ReadKey();
        }
    }
}
