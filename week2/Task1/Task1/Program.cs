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
        public static void palindrome(string s)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Аружан\Desktop\pp2\PP2\week2\input.txt");

            string text = sr.ReadLine();

            bool check = true;

            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != text[text.Length - 1 - i])
                {
                    check = false;
                }
            }

            if (check) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            sr.Close();
        }

        static void Main(string[] args)
        {
            palindrome(s);
        }
    }
}
