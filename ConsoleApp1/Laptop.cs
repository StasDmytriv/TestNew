using System.Collections;
namespace ConsoleApp1;

public class Laptop : IComparable,ICloneable
{
    public string Name { get; set; }
    public DateTime Year { get; set; }
    public Model Model { get; set; }

    public override string ToString()
    {
        return $"{Name}\t{Year.ToShortDateString}\t{Model}";
    }

    public int CompareTo(object? obj)
    {
        return Name.CompareTo(((Laptop)obj).Name);
    }

    public object Clone()
    {
        Laptop laptop = (Laptop)this.MemberwiseClone();
        laptop.Model = (Model)this.Model.Clone();
        return laptop;
    }
}
