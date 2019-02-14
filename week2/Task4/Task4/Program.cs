using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        public static void CreateFile() // creating a file using the function
        {
            FileInfo file = new FileInfo(@"C:\Users\Аружан\Desktop\pp2\week2\Task4\file.txt");
            FileStream fs = file.Create();
        }

        public static void CopyFile() // fucnt which copies files
        {
            string path1 = @"C:\Users\Аружан\Desktop\pp2\week2\Task4\file.txt";
            string path2 = @"C:\Users\Аружан\Desktop\pp2\week2\Task4\file.txt";
            FileInfo f1 = new FileInfo(path1);
            FileInfo f2 = new FileInfo(path2);
            f1.CopyTo(path2);
        }

        public static void DeleteFile()
        {
            FileInfo f = new FileInfo(@"C:\Users\Аружан\Desktop\pp2\week2\Task4\file.txt");
            f.Delete(); // xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        }
        static void Main(string[] args)
        {
            CreateFile();
        }
    }
}
