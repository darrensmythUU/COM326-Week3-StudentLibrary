using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPractical_StudentLibrary
{
    public class Student
    {
        // Private Fields
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        // Get/Set Constructors
        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        // Constructors for Student object
        public Student()
        {
            id = studentCount++;
            this.Name = "John Doe";
            this.Age = 16;
        }

        public Student(string studentName, int studentAge)
        {
            id = studentCount++;
            this.Name = studentName;
            this.Age = studentAge;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Address: {Age}");
            Console.WriteLine();
        }

        public int GetOlder()
        {
            return age++;
        }
    }
}