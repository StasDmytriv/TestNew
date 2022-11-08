namespace ConsoleApp1;

public class StudentCard 
{
    public int Number { get; set; } 

    public string Seria { get; set; }


    public override string ToString()
    {
        return $"{Seria}:{Number}"; 
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
