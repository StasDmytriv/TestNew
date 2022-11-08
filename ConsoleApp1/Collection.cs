using System.Collections;

namespace ConsoleApp1;

public class Collection
{
    public Hashtable _hastable;
    public ArrayList _arrayList;

    public void add(object value)
    {
        _arrayList.Add(value);
    }

    public void add(object key,object value)
    {
        _hastable.Add(key,value);
    }

    public object this[int index] 
    {
        get 
        {
           if(index < 0 || index >= _arrayList.Count)
                throw new IndexOutOfRangeException();

            return _arrayList[index];
        }
        set
        {
            if (index < 0 || index >= _arrayList.Count)
                throw new IndexOutOfRangeException();

            _arrayList[index] = value;
        }
    }

    public object this[object key] 
    {
        get
        {
            if (_hastable.ContainsKey(key))
                return _hastable[key];

            throw new KeyNotFoundException();

        }
        set
        {
            if (_hastable.ContainsKey(key))
                _hastable[key] = value;

            throw new KeyNotFoundException();
        }
    }

    public void RemoveA(object obj)
    {
        _arrayList.Remove(obj);
    }

    public void RemoveH(object key)
    {
        if(_hastable.ContainsKey(key))
            _hastable.Remove(key);

        throw new KeyNotFoundException();
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _arrayList.Count)
            throw new IndexOutOfRangeException();

        _arrayList.RemoveAt(index);
    }
}
