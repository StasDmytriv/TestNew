namespace ConsoleApp1;

public class Math
{
    private Drob[] drobs;

    public Drob this[string name]
    {
        get
        {
            foreach (var item in drobs)
                if (item.Name == name)
                    return item;

            throw new NullReferenceException();
        }
    }

    public Drob this[int index]
    { 
        get 
        {
            if (index < 0 && index >= drobs.Length)
                throw new IndexOutOfRangeException();
            return drobs[index];
        }
        set
        {
            if (index < 0 && index >= drobs.Length)
                throw new IndexOutOfRangeException();
            drobs[index] = value;
        }
    }

}
