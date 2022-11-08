namespace ConsoleApp2;

public delegate void ExamDelegate(string task);

[Coder]

public sealed class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }


    [Coder("Constructor")]

    public Student()
    {
        Id = 0;
        Name = string.Empty;
        Age = 0;
    }

    public void ExamStudent(string task)
    {
        Console.WriteLine($"Student {Name} solved the {task}");
    }

    public override string ToString()
    {
        return $"{Id} {Name}";
    }
}
