namespace ConsoleApp1;

public class MyException : Exception
{
    public DateTime TimeException { get; set; }

    private const string message = "My Exception";


    public MyException(DateTime timeException)
    {
        TimeException = DateTime.Now;
    }

    public MyException(string Message)
    {
        Message = message;
    }

    public MyException() { }

    public override string Message
    {
        get { return Message; }
    }
}
