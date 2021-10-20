using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class A
{
    private static TextReader reader;
    private static TextWriter writer;

    private static int EvaluateFunction(int a, int b, int c, int x)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var list = ReadList();
        writer.WriteLine(EvaluateFunction(list[0], list[1], list[2], list[3]));

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
