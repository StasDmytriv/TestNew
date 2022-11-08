using ConsoleApp1.Interface;

namespace ConsoleApp1;

public class Duck : IBird
{
    public string Name { get ; set ; }

    public void Food()
    {
        Console.WriteLine("Plant");
    }

    public void Say()
    {
        Console.WriteLine("Duck");
    }
}
