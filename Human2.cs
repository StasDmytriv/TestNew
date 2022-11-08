using System;

namespace ConsoleApp1;

public abstract class Human2
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public DateTime Birth { get; set; }

    public Human2(string fname, string lname)
    {
        Fname = fname;
        Lname = lname;
    }

    public override string ToString()
    {
        return $"Firstname: {Fname}\t Lastname: {Lname}";
    }
}
