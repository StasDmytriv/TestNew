using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public struct CalcDouble : ICalc<CalcDouble>
{
    public double A { get; set; }

    public double B { get; set; }

    public CalcDouble()
    {
        A = default(double);
        B = default(double);
    }

    public CalcDouble(double a,double b)
    {
        A = a;
        B = b;
    }

    public CalcDouble Sum(params CalcDouble[] arr)
    {
        throw new NotImplementedException();
    }
}
