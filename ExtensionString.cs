namespace ConsoleApp2;

public static class ExtensionString
{
    public static int NumberWords(this string data)
    {
        if (string.IsNullOrEmpty(data))
            return 0;

        string[] words = data.Split(new char[] { ' ', '.', ',' },StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
