namespace ConsoleApp1;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    public Type type { get; set; }

    public Animal() : this("Animal", 0, "", Type.None) { }
    public Animal(string name, int age, string country, Type type)
    {
        this.Name = name;
        this.Age = age;
        this.Country = country;
        this.type = type;
    }   

    public void Show()
    {
        Console.WriteLine($"name {Name}, age {Age}, country {Country}, type {type}");
    }
}

public enum Type
{
    None,
    Cat,
    Dog,
    Rat
}