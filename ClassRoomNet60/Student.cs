using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int Birthday { get; set; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;

            if (birthMonth >= 1 && birthMonth <= 12)
            {
                BirthMonth = birthMonth;
            }
            else
            {
                BirthMonth = 1;
            }

            Birthday = birthday;
        }

        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth <= 2)
            {
                return "Winter";
            }
            if (BirthMonth >= 3 && BirthMonth <= 5)
            {
                return "Spring";
            }
            if (BirthMonth >= 6 && BirthMonth <= 8)
            {
                return "Summer";
            }
            else
            {
                return "Autumn";
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}