namespace ConsoleApp2;

public delegate T  CalcDelegate<T>(T x, T y);
public delegate void VoidTestDelegate(string s, int a);
public delegate void VoidStringDelegate(string s, int a);
public delegate bool VoidBoolDelegate(bool a);
public delegate T GenericDelegate<T>(T x);

public class Calculator
{
    public double AddDouble(double x, double y)
    {
        return x + y;
    }

    public int AddInt(int x, int y)
    {
        return x + y;
    }

    public static int SubInt(int x, int y)
    {
        return x - y;
    }

    public static double SubDouble(double x, double y)
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

    public static void StaticVoidTest(string s,int a)
    {
        Console.WriteLine($"{a}: {s}");
    }

    public static void StaticStringTest(string s, int a)
    {
        Console.WriteLine($"Key: {a},value: {s}");
    }

    public static bool StaticBoolTest(bool a)
    {
        if (a == true)
            return true;
        return false;
    }

    public static int StaticGenericTest(int a)
    {
        return a;
    }

    public static string StaticGenericTest(string a)
    {
        return a;
    }

    public static void TestAction1(string s,int a,double d)
    {
        Console.WriteLine(s);
        Console.WriteLine(a);
        Console.WriteLine(d);
    }

    public static void TestAction2(string s, int a, double d)
    {
        Console.WriteLine(d);
        Console.WriteLine(a);
        Console.WriteLine(s);
    }

    public static string TestFunc(string s,int a,double d)
    {
        return s + a + d;
    }

    public static bool TestPredicate(int a)
    {
        return a > 0;
    }


    public static void Action1(string s, int a)
    {
        Console.WriteLine(s);
    }

    public static void Action2(string s, int a)
    {
        Console.WriteLine(s + a);
    }

    public static void Action3(string s, int a)
    {
        Console.WriteLine(a);
    }

    public static string Func1(int a, int b,int c)
    {
        return  (a).ToString();
    }

    public static string Func2(int a, int b, int c)
    {
        return (b).ToString();
    }

    public static string Func3(int a, int b, int c)
    {
        return (c).ToString();
    }

    public static bool Predicate1(bool a)
    {
        return true;
    }
    public static bool Predicate2(bool a)
    {
        return false;
    }

    public static bool Predicate3(bool a)
    {
        return a;
    }
}

