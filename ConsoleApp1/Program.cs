
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student(20, 2),
            new Student(21, 3),
            new Student(19, 1),
            new Student(22, 4)
        };

        students.Sort((studentA, studentB) => studentA.CompareTo(studentB));


        foreach (var student in students)
        {
            Console.WriteLine($"Age: {student._age}, Year: {student._year}");
        }
    }
}