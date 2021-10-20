using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class D
{
    private static TextReader reader;
    private static TextWriter writer;

    private static int GetWeatherRandomness(List<int> temperatures)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var numberOfDays = ReadInt();
        var temperatures = ReadList();
        var chaosNumber = GetWeatherRandomness(temperatures);

        writer.WriteLine(chaosNumber);

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

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}
