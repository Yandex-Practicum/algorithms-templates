using System;
using System.IO;

public class L
{
    private static TextReader reader;
    private static TextWriter writer;

    private static char GetExcessiveLetter(string s, string t)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var s = reader.ReadLine();
        var t = reader.ReadLine();
        writer.WriteLine(GetExcessiveLetter(s, t));

        reader.Close();
        writer.Close();
    }
}
