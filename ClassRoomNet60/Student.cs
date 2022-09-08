using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int Birthday { get; private set; }

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
            else if (BirthMonth >= 3 && BirthMonth <= 5)
            {
                return "Spring";
            }
            else if (BirthMonth >= 6 && BirthMonth <= 8)
            {
                return "Summer";
            }
            else if (BirthMonth >= 9 && BirthMonth <= 11)
            {
                return "Autumn";
            }
            else
            {
                return "No Season";
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Birth Month: {BirthMonth}, Birthday: {Birthday}";
        }
    }
}