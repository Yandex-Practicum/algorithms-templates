using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class A
{
    private static TextReader reader;
    private static TextWriter writer;

    public static int GetSum(int a, int b)
    {
        // Здесь реализация вашего решения
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var ints = ReadList();
        writer.WriteLine(GetSum(ints[0], ints[1]));

        reader.Close();
        writer.Close();
    }

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }
}
