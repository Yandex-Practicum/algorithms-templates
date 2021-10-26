using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class B
{
    private static TextReader reader;
    private static TextWriter writer;

    public static List<int> Zip(List<int> a, List<int> b)
    {
        // Здесь реализация вашего решения
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var arrayA = ReadList();
        var arrayB = ReadList();
        writer.WriteLine(string.Join(" ", Zip(arrayA, arrayB)));

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }
}
