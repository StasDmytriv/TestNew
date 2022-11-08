namespace ConsoleApp1.Interface;

public interface IAnimal : IWings, IClaws, IHead, IPaw
{
    public string Name { get; set; }

    public void Food() { }

    public void Say() { }
}
