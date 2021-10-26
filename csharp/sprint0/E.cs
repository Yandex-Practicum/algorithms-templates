using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class E
{
    private static TextReader reader;
    private static TextWriter writer;

    // Если ответ существует, верните список из двух элементов
    // Если нет - то верните пустой список
    public static List<int> TwoSum(List<int> sortedArray, int targetSum)
    {
        // Здесь реализация вашего решения
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var sortedArray = ReadList();
        var targetSum = ReadInt();
        var result = TwoSum(sortedArray, targetSum);
        writer.WriteLine(result.Any() ? "None" : string.Join(" ", result));

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
