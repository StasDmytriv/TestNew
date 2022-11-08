﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Point2D<T> where T : struct
{
    public T X { get; set; }

    public T Y { get; set; }


    public Point2D(T x, T y)
    {
        X = x;
        Y = y;
    }

    public Point2D()
    {
        X = default(T);
        Y = default(T);
    }

    public override string ToString()
    {
        return $"{X} {Y}";
    }
}
