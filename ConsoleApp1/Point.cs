using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;

namespace ConsoleApp1;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator++(Point s)
    {
        s.X++;
        s.Y++;
        return s;
    }

    public static Point operator --(Point s)
    {
        s.X--;
        s.Y--;
        return s;
    }

    public static Point operator - (Point s)
    {
        return new Point { X=-s.X,Y=-s.Y};
    }

    public static Point operator +(Point s)
    {
        return new Point { X = +s.X, Y = +s.Y };
    }

    public static Point operator +(Point point1,Point point2)
    {
        return new Point { X = point1.X+point2.X, Y = point1.Y + point2.Y};
    }

    public static Point operator -(Point point1, Point point2)
    {
        return new Point { X = point1.X - point2.X, Y = point1.Y - point2.Y };
    }

    public static Point operator *(Point point1, Point point2)
    {
        return new Point { X = point1.X * point2.X, Y = point1.Y * point2.Y };
    }

    public static Point operator /(Point point1, Point point2)
    {
        return new Point { X = point1.X / point2.X, Y = point1.Y / point2.Y };
    }

    public static int operator +(int a,Point point1)
    {
        return point1.X + a + point1.Y;
    }

    public override string ToString()
    {
        return $"X:{X}, Y:{Y}";
    }

    public static bool operator > (Point point1, Point point2)
    {
        return point1.X > point2.X;
    }

    public static bool operator <(Point point1, Point point2)
    {
        return point1.X < point2.X;
    }

    public static bool operator ==(Point point1, Point point2)
    {
        return point1.X == point2.X;
    }

    public static bool operator !=(Point point1, Point point2)
    {
        return point1.X != point2.X;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode()+ Y.GetHashCode();
    }

    //public override bool Equals(object? obj)
    //{
    //    if (obj == null || obj is not Point)
    //        return false;
    //    Point p = obj as Point;
    //    if (X.GetHashCode() == p.X && p.Y)
    //        return true;
    //    else return false;
    //    return base.Equals(obj);
    //}

    public static bool operator true(Point point)
    {
        return point.X != 0 && point.Y != 0;
    }

    public static bool operator false(Point point)
    {
        return point.X == 0 || point.Y == 0;
    }

    public static Point operator |(Point point1, Point point2)
    {
        if (point1.X != 0 && point2.X != 0)
            return point1;
        return point2;
    }

    public static Point operator &(Point point1, Point point2)
    {
        if (point1 || point2)
            return point1;
        else return point2;
    }
}
