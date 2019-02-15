using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // creating class with student info and declare it
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
            Console.WriteLine(name + " " + ID + " " + year); // print name, id and year
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student info = new Student("Aruzhan", "18BD110118"); // give znacheniya to funct Student 
            info.print(); // use class Student and call funct that prints the znacheniya

            Console.ReadKey();
        }

    }
}
