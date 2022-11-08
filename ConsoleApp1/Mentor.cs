namespace ConsoleApp1;

public class Mentor : Employee
{
    public string Mentie { get;private set; }

    public Mentor(string firstname, string lastname, int salary, string mentie): base (firstname,lastname,salary)
    {
        Mentie = mentie;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine(Mentie);
    }
}
