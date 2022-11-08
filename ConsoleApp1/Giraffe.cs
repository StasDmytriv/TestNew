using ConsoleApp1.Interface;
namespace ConsoleApp1;

public class Giraffe : IAnimal
{
    public string Name { get; set; }

    public void Say()
    {
        Console.WriteLine("Giraffe");
    }

    public void Food()
    {
        Console.WriteLine("Plant");
    }
}
