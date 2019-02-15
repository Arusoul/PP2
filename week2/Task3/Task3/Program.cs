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
                Console.Write("   ");
            }
        }

        static void task(DirectoryInfo direct, int lvl)
        {
            FileInfo[] files = direct.GetFiles(); // an array with info about files
            DirectoryInfo[] directories = direct.GetDirectories(); // // an array with folders

            foreach(FileInfo file in files)
            {
                PrintSpace(lvl); // call the funct with spaces for each level
                Console.WriteLine(file.Name); // print names of the files
            }

            foreach(DirectoryInfo d in directories)
            {
                PrintSpace(lvl);
                Console.WriteLine(d.Name); // names of the folders
                task(d, lvl + 1); // call the funct again
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Аружан\Desktop\pp2\week2"); // get info from the folder
            task(d, 1); // start the funct

            Console.ReadKey();
        }
    }
}
