using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class B
{
    private static TextReader reader;
    private static TextWriter writer;

    private static bool CheckParity(int a, int b, int c)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var list = ReadList();
        if (CheckParity(list[0], list[1], list[2]))
        {
            writer.WriteLine("WIN");
        }
        else
        {
            writer.WriteLine("FAIL");
        }

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
