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
                if (result == "Spring")
                {
                    spring++;
                }
                if (result == "Summer")
                {
                    summer++;
                }
                else
                {
                    autumn++;
                }
            }

            return $"Winter: {winter}\nSpring: {spring}\nSummer: {summer}\nAutumn: {autumn}";
        }
    }
}