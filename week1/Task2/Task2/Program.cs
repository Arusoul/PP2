using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string ID;
        public int year = 1;

        public Student (string name, string ID)
        {
            this.name = name;
            this.ID = ID;
        }
        public void print()
        {
            year++;
            Console.WriteLine(name + " " + ID + " " + year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student info = new Student("Aruzhan", "18BD110118");
            info.print();
        }
    }
}
