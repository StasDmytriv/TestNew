using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class CalcInt : ICalc<int>
{
    public int Sum(params int[] arr)
    {
        return arr.Sum();
    }
}
