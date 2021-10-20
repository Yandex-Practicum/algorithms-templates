using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class K
{
    private static TextReader reader;
    private static TextWriter writer;

    private static List<int> GetSum(List<int> numberList, int k)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var numberLength = ReadInt();
        var numberList = ReadList();
        var k = ReadInt();
        var sum = GetSum(numberList, k);

        writer.WriteLine(string.Join(" ", sum));

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
