using ConsoleApp1.Interface;
using System.Collections;

namespace ConsoleApp1;

public class Pets : IEnumerable,ICloneable
{
    IHead[] heads = new IHead[]
    {
        new Duck(),
        new Chicken(),
        new Dog(),
        new Cat()
    };


    public object Clone()
    {
        Pets clone = (Pets)this.MemberwiseClone();
        clone.heads = (IHead[])heads.Clone();
        return clone;
    }

    public IEnumerator GetEnumerator()
    {
        return heads.GetEnumerator();
    }
}
