using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Classroom
    {
        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public Classroom()
        {
            ClassList = new List<Student>();
        }

        public string Count()
        {
            int winter = 0;
            int spring = 0;
            int summer = 0;
            int autumn = 0;

            foreach (Student student in ClassList)
            {
                string result = student.Season();

                if (result == "Winter")
                {
                    winter++;
                }
                else if (result == "Spring")
                {
                    spring++;
                }
                else if (result == "Summer")
                {
                    summer++;
                }
                else if (result == "Autumn")
                {
                    autumn++;
                }
            }

            return $"Winter: {winter}\nSpring: {spring}\nSummer: {summer}\nAutumn: {autumn}";
        }
    }
}