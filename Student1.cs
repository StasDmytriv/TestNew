using System.Runtime.Serialization;

namespace ConsoleApp2;

public class Student1 : ISerializable
{
    public int Id { get; set; } 

    public string Name { get; set; }

    public int Age { get; set; }

    public string University { get; set; }

    public DateTime DateNow { get; set; }  

    [NonSerialized]
    public const string city = "Lviv";

    public Student1() { }

    public Student1(int id)
    {
        this.Id = id;
    }

    public Student1(int id, string name, int age, string university)
    {
        this.Id = id;
        Name = name;
        Age = age;
        University = university;
    }

    public override string ToString()
    {
        return $"{Id}\t {Name}\t {Age}\t {University}\t {city}";
    }

    private Student1(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetInt32("Id");
        DateNow = info.GetDateTime("DateNow");
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Id", 42);
        info.AddValue("DateNow", DateTime.Today);
    }
}
