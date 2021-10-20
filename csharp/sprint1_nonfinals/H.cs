using System;
using System.IO;

public class H
{
    private static TextReader reader;
    private static TextWriter writer;

    private static string SumOfBinaries(string a, string b)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var a = reader.ReadLine();
        var b = reader.ReadLine();
        writer.WriteLine(SumOfBinaries(a, b));

        reader.Close();
        writer.Close();
    }
}
