namespace ConsoleApp2;

[Serializable]
public class Animal
{
    [NonSerialized]
    private int id;

    public string Name { get; set; }

    public int Age { get; set; }

    public List<string> Food { get; set; }


    public Animal(int id)
    {
        this.id = id;
    }

    public override string ToString()
    {
        return $"{id}\t {Name}\t {Age}\t {Food}";
    }
}
