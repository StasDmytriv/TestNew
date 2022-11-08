namespace ConsoleApp1.Interface;

public interface IZoo
{
    public IAnimal[] Animals { get; set; }
    IAnimal this[int index] { get; set; }

    public void Say();

    public void Food(); 
}
