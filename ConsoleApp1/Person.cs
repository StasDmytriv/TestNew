using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Person : IPerson
{
    public string name;
    public int age;    

    public string Name
    {
        get { return name; } 
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                name = "default";
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (age>=0)
                age = value;
            else
                age=int.MinValue;
        }
    }

   
    public Person(string name,int age)
    {
       
    }
}
