using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpace(int lvl) // spaces for every line before text
        {
            for(int i = 0; i < lvl; i++)
            {
                Console.Write(" ");
            }
        }

        static void task(DirectoryInfo direct, int lvl)
        {
            FileInfo[] files = direct.GetFiles(); // an array with info about files
            DirectoryInfo[] directories = direct.GetDirectories(); // // an array with xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz

            foreach(FileInfo file in files)
            {
                PrintSpace(lvl); // call the fuct with spaces for levels
                Console.WriteLine(file.Name); // write names of the files to see them
            }

            foreach(DirectoryInfo d in directories)
            {
                PrintSpace(lvl);
                Console.WriteLine(d.Name); // xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz files of the files????????
                task(d, lvl + 1); // xzzzzzzzzzzzzzzzzz
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Аружан\Desktop\pp2\week2");
            task(d, 1);
            Console.ReadKey();
        }
    }
}
