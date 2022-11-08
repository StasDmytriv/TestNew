using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Points <T> : ILenght where T : struct
{
    public Point2D<T> Point1 { get; set; }

    public Point2D<T> Point2 { get; set; }


    public Points(Point2D<T> Point1, Point2D<T> Point2)
    {
        this.Point1 = Point1;
        this.Point2 = Point2;
    }

    public Points(T X1,T X2,T Y1,T Y2)
    {
        Point1 = new Point2D<T>(X1,Y1);
        Point2 = new Point2D<T>(X2,Y2);
    }

    public override string ToString()
    {
        return $"X1:{Point1.X} Y1:{Point1.Y} X2:{Point2.X} Y2:{Point2.Y}";
    }

    public double Sum(params double[] args)
    {
        return args.Sum();
    }

    public string Str<U>(params U[] args)
    {
        string result = "";
        foreach (var item in args)
        {
            result += item.ToString();
        }
        return result;
    }
}
