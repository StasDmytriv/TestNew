namespace ConsoleApp1.Interface;

internal interface IManager
{
    public bool IsWorking { get; }
    public string Work();
}
