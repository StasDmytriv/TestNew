namespace ConsoleApp2;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Constructor)]

public class CoderAttribute : Attribute
{
    public CoderAttribute()
    {

    }

    public CoderAttribute(string coder)
    {
        Console.WriteLine(coder);
    }
}
