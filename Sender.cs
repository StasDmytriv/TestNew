using System.Xml.Linq;

namespace ConsoleApp2;

public delegate void EmailDelegate(string mail);

public sealed class Sender
{
    public string Title { get; set; }

    public void GetMail(string mail)
    {
        Console.WriteLine($"You recieved {Title} from {mail}");
    }

}
