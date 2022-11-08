namespace ConsoleApp1;

public class Human
{
    private readonly Random random;
    private int Id { get; set; }
    protected string Fname { get; set; }
    protected string Lname { get; set; }
    public DateTime Birth { get; set; }

    public Human(string fname, string lname)
    {
        random = new Random();
        Id = random.Next(1000);
        Fname = fname;
        Lname = lname;
    }   

    public Human(string fname, string lname,DateTime birth)
    {
        random = new Random();
        Id = random.Next(1000);
        Fname = fname;
        Lname = lname;
        Birth = birth;
    }

    public void Print()
    {
        Console.WriteLine($"{Id} ,{Fname} ,{Lname} ,{Birth.ToShortDateString()}");
    }
}