using System;
using System.Xml.Linq;

namespace ConsoleApp1;

public class Drob
{
    public string Name { get; set; }
    public double a { get; set; }
    public double b { get; set; }

    public Drob(double A, double B)
    {
        this.a = A;
        this.b = B;
    }

    public override string ToString()
    {
        return $"{a}\n--\n{b}";
    }

    public static Drob operator +(Drob f1, Drob f2)
    {
        var result = new Drob(f1.a * f2.b + f2.a * f1.b, f1.b * f2.b);
        return result;
    }

    public static Drob operator -(Drob f1, Drob f2)
    {
        var result = new Drob(f1.a * f2.b - f2.a * f1.b, f1.b * f2.b);
        return result;
    }

    public static Drob operator *(Drob f1, Drob f2)
    {
        var result = new Drob(f1.a * f1.b,f2.a * f2.b);
        return result;
    }

    public static Drob operator /(Drob f1, Drob f2)
    {
        var result = new Drob(f1.a * f2.b, f2.b * f1.a);
        return result;
    }

    public static Drob operator +(Drob f1,double a)
    {
        return f1 + new Drob (a * f1.b, f1.b);
    }

    public static Drob operator +(double a, Drob f1)
    {
        return f1 + new Drob(a * f1.b, f1.b);
    }

    public static Drob operator -(Drob f1, double a)
    {
        return f1 - new Drob(a * f1.b, f1.b);
    }

    public static Drob operator -(double a, Drob f1)
    {
        return f1 - new Drob(a * f1.b, f1.b);
    }

    public static Drob operator *(Drob f1, double a)
    {
        return f1 * new Drob(a * f1.b, f1.b);
    }

    public static Drob operator *(double a, Drob f1)
    {
        return f1 * new Drob(a * f1.b, f1.b);
    }

    public static Drob operator /(Drob f1, double a)
    {
        return f1 / new Drob(a * f1.b, f1.b);
    }

    public static Drob operator /(double a, Drob f1)
    {
        return f1 / new Drob(a * f1.b, f1.b);
    }

    public static bool operator >(Drob point1, Drob point2)
    {
        return point1.a > point2.a;
    }

    public static bool operator <(Drob point1, Drob point2)
    {
        return point1.a < point2.a;
    }

    public static bool operator ==(Drob point1, Drob point2)
    {
        return point1.a == point2.a;
    }

    public static bool operator !=(Drob point1, Drob point2)
    {
        return point1.a != point2.a;
    }

    public override int GetHashCode()
    {
        return a.GetHashCode() + b.GetHashCode();
    }

    public static bool operator true(Drob d)
    {
        return d.a != 0 && d.b != 0;
    }

    public static bool operator false(Drob d)
    {
        return d.a == 0 || d.b == 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Point)
            return false;
        Drob p = obj as Drob;
        if (a.GetHashCode() == p.a.GetHashCode() && a.GetHashCode() == p.b.GetHashCode())
            return true;
        else return false;
        return base.Equals(obj);
    }

    public static Drob operator |(Drob d1, Drob d2)
    {
        if (d1.a != 0 && d2.a != 0)
            return d1;
        return d2;
    }

    public static Drob operator &(Drob d1, Drob d2)
    {
        if (d1 || d2)
            return d1;
        else return d2;
    }

    public static implicit operator Drob(double d)
    {
        return new Drob ( d, d );
    }

    public static explicit operator double(Drob d)
    {
        return d.a + d.b;
    }
}