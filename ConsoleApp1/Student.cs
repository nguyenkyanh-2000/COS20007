namespace ConsoleApp1;

public class Student
{
    public int _age;
    public int _year;

    public Student(int age, int year)
    {
        _age = age;
        _year = year;
    }

    public int CompareTo(Student other)
    {
        int yearComparison = other._year.CompareTo(_year);
        if (yearComparison == 0)
        {
            return other._age.CompareTo(_age);
        }
        return yearComparison;
    }
}