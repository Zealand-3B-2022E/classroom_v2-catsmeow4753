using ClassRoomNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        Classroom classroom_1 = new Classroom();
        classroom_1.ClassName = "3Q";
        classroom_1.SemesterStart = new DateTime();

        classroom_1.ClassList.Add(new Student("Bob1", 1, 2));
        classroom_1.ClassList.Add(new Student("Bob2", 3, 4));
        classroom_1.ClassList.Add(new Student("Bob3", 8, 4));
        classroom_1.ClassList.Add(new Student("Bob4", 8, 7));
        classroom_1.ClassList.Add(new Student("Bob5", 9, 10));

        Console.WriteLine($"Class Name: {classroom_1.ClassName}\nSemester Start: {classroom_1.SemesterStart}");

        Console.WriteLine("Class List:");
        foreach (Student student in classroom_1.ClassList)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(classroom_1.Count());
    }
}