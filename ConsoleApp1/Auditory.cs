using System.Collections;
namespace ConsoleApp1;

public class Auditory : IEnumerable
{
    private Student[] students;

    public Auditory()
    {
        students = new Student[] 
        {
            new Student{FirstName="FirstName1",LastName="LastName3",
                DateTime=new DateTime(2000,12,12),StudentCard=new StudentCard{Number=100,Seria="BA"}},
            new Student{FirstName="FirstName2",LastName="LastName2",
                DateTime=new DateTime(2000,11,13),StudentCard=new StudentCard{Number=124,Seria="BC"}},
            new Student{FirstName="FirstName3",LastName="LastName1",
                DateTime=new DateTime(2000,10,14),StudentCard=new StudentCard{Number=195,Seria="BB"}},
            new Student{FirstName="FirstName4",LastName="LastName4",
                DateTime=new DateTime(2000,09,15),StudentCard=new StudentCard{Number=231,Seria="BD"}},
            new Student{FirstName="FirstName5",LastName="LastName5",
                DateTime=new DateTime(2000,08,16),StudentCard=new StudentCard{Number=127,Seria="BF"}}
        };
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < students.Length; i++)
        {
            yield return students[i];
        }
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students,comparer);
    }
}