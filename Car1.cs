using System.Xml.Linq;

namespace ConsoleApp2;

public class Car1
{
    private int id;

    public int Year { get; set; }

    public string Model { get; set; }

    public Mark Mark { get; set; }


    public Car1() { }

    public Car1(int id)
    {
        this.id = id;
    }

    public Car1(int id,int year, string model, Mark mark)
    {
        this.id = id;
        Year = year;
        Model = model;
        Mark = mark;
    }

    public override string ToString()
    {
        return $"{id}\t {Year}\t {Model}\t {Mark}";
    }
}

public enum Mark
{
    Mercedes,
    Bmw,
    Audi,
    Ford
}