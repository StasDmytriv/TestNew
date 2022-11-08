namespace ConsoleApp1;

public class Manager : Employee
{
    public string Company { get;private set; }

    public Manager(string firstname, string lastname,int salary,string company):base(firstname,lastname,salary)
    {
        Company = company;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine(Company);
    }
}
