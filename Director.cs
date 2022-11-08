using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal interface Director: IManager,IWorker
{
    public bool IsWorking { get { return true; } }

    public void Controll()
    {
        Console.WriteLine("Controll");
    }

    public void MakeBudget()
    {
        Console.WriteLine("Make Budget");
    }

    public void Organize()
    {
        Console.WriteLine("Organize");
    }

    public void Work()
    {
        Console.WriteLine("Hard Work");
    }
}
