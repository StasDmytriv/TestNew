using System.Collections;
namespace ConsoleApp1;

public class Shop1 : IEnumerable,ICloneable
{
    private Laptop[] laptops;

    public Shop1()
    {
        laptops = new Laptop[]
        {
            new Laptop{Name="Asus",Year = new DateTime(20,10,2020),
                Model=new Model{Number=100,Series="BA"}},
            new Laptop{Name="Apple",Year = new DateTime(19,09,2021),
                Model=new Model{Number=120,Series="DA"}},
            new Laptop{Name="Lenovo",Year = new DateTime(18,08,2022),
                Model=new Model{Number=14,Series="CA"}},
            new Laptop{Name="Acer",Year = new DateTime(17,07,2023),
                Model=new Model{Number=101,Series="AA"}},
        };
    }

    public void Sort()
    {
        Array.Sort(laptops);
    }

    public IEnumerator GetEnumerator()
    {
        return laptops.GetEnumerator();
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
