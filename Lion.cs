using ConsoleApp1.Interface;
namespace ConsoleApp1;

public class Lion : IAnimal
{
    public string Name { get; set; }

    public void Say()
    {
        Console.WriteLine("Lion");
    }

    public void Food()
    {
        Console.WriteLine("Meat");
    }

}
