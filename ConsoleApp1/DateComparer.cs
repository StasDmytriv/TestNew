using System.Collections;
namespace ConsoleApp1;

public class DateComparer : IComparer<Student>
{
    public int Compare(Student? x,Student? y)
    {
        if (x != null && y != null )
            return DateTime.Compare(x.DateTime, y.DateTime);

        throw new Exception();
    }
}
