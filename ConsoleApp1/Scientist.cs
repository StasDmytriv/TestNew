namespace ConsoleApp1;

public class Scientist : Employee
{
    public string Direction { get;private set; }

    public Scientist(string firstname, string lastname,int salary,string direction): base (firstname,lastname,salary)
    {
        Direction = direction;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine(Direction);
    }
}
