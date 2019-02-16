using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int sz;
        public FileSystemInfo fsnow = null;
        public DirectoryInfo dir = null;

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            dir = new DirectoryInfo(path);
            sz = dir.GetFileSystemInfos().Length; // size of directories plus files in it
        }

        public void Colour(FileSystemInfo f, int index)
        {
            if (cursor == index)
            { // higliht the directory of the file which is shown
                fsnow = f;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (f.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen; // if its a directory paint it to green
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // otherwise to yellow
            }
        }

            public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            dir = new DirectoryInfo(path);
            int ind = 1;
            FileSystemInfo[] fs = dir.GetFileSystemInfos(); // we add to array all filesysteminfos(directories and files) from given directory

            for (int i = 0; i < fs.Length; i++)
            {
                Colour(fs[i], i); // colour each element of the array
                Console.WriteLine(ind + "." + " " + fs[i]);
                ind++;
            }
        }

        public void Up() // the funct to go up of the list
        {
            cursor--;
            if (cursor < 0) // if we go above the first element, cursor goes go to the last one
            {
                cursor = sz - 1;
            }
        }

        public void Down()
        {
            cursor++;
            if (cursor == sz) // if we go down the las element, cursor goes go to the first one
            {
                cursor = 0;
            }
        }

        public void Start()
        {
            ConsoleKeyInfo keyinfo = Console.ReadKey();
            while (keyinfo.Key != ConsoleKey.Escape) // if we press escape the ptogramm stops working
            {
                Show();
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    Up();
                }
                else if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    Down();
                }
                if (keyinfo.Key == ConsoleKey.Enter) // if we choose the element press enter
                {
                    if (fsnow.GetType() == typeof(FileInfo))
                    {
                        cursor = 0;
                        path = fsnow.FullName; //if it's directory it will return the pass which includes this directory too
                        // it mewns we go to the directory
                    }
                    if (fsnow.GetType() == typeof(FileInfo)) // if it's file we open it in the console (text files)
                    {
                        cursor = 0;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        using (StreamReader sr = new StreamReader(fsnow.FullName)) // we read the context of a file
                        {
                            Console.WriteLine(sr.ReadToEnd()); // print the funct RedaToEnd
                        }
                        Console.ReadKey();

                    }
                }
                if (keyinfo.Key == ConsoleKey.Delete) // delete elements of an array using "delete" button
                {
                    cursor = 0;
                    if (fsnow.GetType() == typeof(DirectoryInfo))
                    {
                        if (new DirectoryInfo(fsnow.FullName).GetFileSystemInfos().Length == 0) // if it's directory which is empty then no promblem it will be deleted
                            Directory.Delete(fsnow.FullName);
                    }
                    else // but this directory has files or subdirectories we ask if they sure
                    {
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        if (Console.ReadKey().Key == ConsoleKey.Y) // if yes then delete
                        {
                            Directory.Delete(fsnow.FullName, true);
                        }

                    }
                }

                else if (fsnow.GetType() == typeof(FileInfo)) // deleting the files
                {
                    File.Delete(fsnow.FullName);
                }
            }

            if (keyinfo.Key == ConsoleKey.I) // by pressing I we rename the give file or directory
            {
                cursor = 0;
                if (fsnow.GetType() == typeof(DirectoryInfo))
                {
                    Console.Clear();
                    string s = Console.ReadLine(); // we write the name which we want to change
                    string Name = fsnow.Name;// just simple name of directory
                    string fName = fsnow.FullName; // location of directory
                    string newpath = "";

                    for (int i = 0; i < fName.Length - Name.Length; i++)
                    {
                        newpath += fName[i]; // the path which keeps the location of directory
                    }
                    newpath = newpath + s;
                    Directory.Move(fName, newpath); // changes the name
                }

                else
                {
                    Console.Clear();
                    string s = fsnow.Name;
                    string Name = fsnow.Name;
                    string fName = fsnow.FullName;
                    string newpath = "";

                    for (int i = 0; i < fName.Length - Name.Length; i++)
                    {
                        newpath += fName[i];
                    }
                    newpath = newpath + s;
                    File.Move(fName, newpath);
                }
            }

            if (keyinfo.Key == ConsoleKey.Backspace) // if press backspace i return to the last folder
            {
                cursor = 0;
                path = dir.Parent.FullName;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Аружан\Desktop\pp2";
            FarManager fr = new FarManager(path);
            fr.Start();
        }
    }
}
