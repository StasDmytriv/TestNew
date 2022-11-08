using ConsoleApp1.Interface;

namespace ConsoleApp1;

public class Zoo : IZoo
{
    public IAnimal[] Animals { get; set; }

    public IAnimal this[int index]
    {
        get { return Animals[index]; }
        set
        {
            if (index < 0 || index >= Animals.Length)
                throw new IndexOutOfRangeException();
            Animals[index] = value;
        }
    }

    public void Say()
    {
        foreach (var i in Animals)
        {
            i.Say();
        }
    }

    public void Food()
    {
        foreach (var i in Animals)
        {
            i.Food();
        }
    }
}
