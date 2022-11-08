namespace ConsoleApp1;

public class Employee : Human
{
    private int salary;

    public int Salary 
    {
        get { return salary; }
        set 
        { 
            if(value > 0)
                salary = value;
            else
                salary = 0;
        }
    }

    public Employee(string firstname,string lastname,int salary):base (firstname, lastname) 
    {
        Salary = salary;
    }

    public Employee(string firstname, string lastname, int salary,DateTime birth) : base (firstname, lastname, birth)
    {
        Salary = salary;
    }

    public virtual void Print()
    {
        base.Print();
        Console.WriteLine(Salary);  
    }
}
