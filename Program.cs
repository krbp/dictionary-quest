using System;

public class Program
{
    public static void Main()
    {
        Dictionary<char, string> dictionary = new()
        {
            ['a'] = "Aa",
            ['b'] = "Bb",
            ['c'] = "Cc"
        };
        dictionary.Remove('c');
    }
}
