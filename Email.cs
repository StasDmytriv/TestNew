namespace ConsoleApp2;

public class Email
{
    public event EmailDelegate GetMail;

    public void Send(string mail)
    {
        if (GetMail != null)
            GetMail(mail);
    }
}
