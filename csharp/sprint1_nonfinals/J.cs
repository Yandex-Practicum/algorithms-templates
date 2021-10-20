using System;
using System.Collections.Generic;
using System.IO;

public class J
{
    private static TextReader reader;
    private static TextWriter writer;

    private static List<int> Factorize(int n)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var factorization = Factorize(n);
        writer.WriteLine(string.Join(" ", factorization));

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}
