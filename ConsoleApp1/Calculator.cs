﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public delegate double CalcDelegate(double x,double y);

public class Calculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public static double Sub(double x, double y)
    {
        return x - y;
    }

    public double Mult(double x, double y)
    {
         return x * y;
    }

    public static double Div(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        throw new ArgumentException();
    }
}

