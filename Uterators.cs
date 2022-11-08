using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Uterators
{
    const int STOP = 10;
    private int limit;


    public Uterators(int limit)
    {
        this.limit = limit;
    }

    public IEnumerable<int> GetNumber()
    {
        for (int i = 0; i < limit; i++)
        {
            if (i == STOP)
                yield break;

            yield return i;
        }
    }
}
