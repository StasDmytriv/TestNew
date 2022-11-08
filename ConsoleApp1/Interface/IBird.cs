namespace ConsoleApp1.Interface;

public interface IBird : IWings,IClaws,IHead,IPaw
{
    public void Bird()
    {
        Console.WriteLine("Bird");
    }
}
