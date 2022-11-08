using ConsoleApp1.Interface;
namespace ConsoleApp1;

public class Snake : IAnimal
{
    public string Name { get; set; }

    public void Say()
    {
        Console.WriteLine("Snake");
    }

    public void Food()
    {
        Console.WriteLine("meat");
    }
}
