using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_GUI
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Year { get; set; }

        public Student(int studentID, string name, string department, int year)
        {
            StudentID = studentID;
            Name = name;
            Department = department;
            Year = year;
        }
    }
}
