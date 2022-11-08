using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public interface ICalc<T>
{
    T Sum(params T[] arr);
}
