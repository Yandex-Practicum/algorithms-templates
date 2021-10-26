using System;
using System.IO;

public class L
{
    private static TextReader reader;
    private static TextWriter writer;

    private static char GetExcessiveLetter(string shorter, string longer)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var shorter = reader.ReadLine();
        var longer = reader.ReadLine();
        writer.WriteLine(GetExcessiveLetter(shorter, longer));

        reader.Close();
        writer.Close();
    }
}
