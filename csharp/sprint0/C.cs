using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class C
{
    private static TextReader reader;
    private static TextWriter writer;

    public static List<double> MovingAverage(List<int> array, int windowSize)
    {
        // Здесь реализация вашего решения
    }

    public static void Print(double[] array)
    {
        writer.WriteLine(string.Join(" ", array));
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var array = ReadList();
        var windowSize = ReadInt();

        writer.WriteLine(string.Join(" ", MovingAverage(array, windowSize)));

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
