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
        static void Main(string[] args)
        {

            Directory.CreateDirectory(@"C:\Users\Аружан\Desktop\pp2\week2\Task4\path"); // create a folder
            Directory.CreateDirectory(@"C:\Users\Аружан\Desktop\pp2\week2\Task4\path1");

            string FilePath = @"C:\Users\Аружан\Desktop\pp2\week2\Task4\path\file.txt"; // shows a path
            string FilePath1 = @"C:\Users\Аружан\Desktop\pp2\week2\Task4\path1\file.txt";

            StreamWriter sw = new StreamWriter(FilePath); // creates a file
            sw.WriteLine(" ");
            sw.Close();

            File.Copy(FilePath, FilePath1); // copies from the first path to the second

            File.Delete(FilePath); // deletes the first path
       
        }

    }
}
