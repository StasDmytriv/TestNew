namespace ConsoleApp2;

[Serializable]
public class Person
{
    [NonSerialized]
    private int id;

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }


    public Person(int id)
    {
        this.id = id;
    }

    public override string ToString()
    {
        return $"{id}\t {FirstName}\t {LastName}\t {Age}"; 
    }
}
