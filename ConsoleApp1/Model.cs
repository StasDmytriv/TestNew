namespace ConsoleApp1;

public class Model:ICloneable
{
    public int Number { get; set; }
    public string Series { get; set; }


    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{Series}:{Number}";
    }

}
