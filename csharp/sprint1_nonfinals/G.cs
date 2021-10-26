using System;
using System.IO;

public class G
{
    private static TextReader reader;
    private static TextWriter writer;

    private static string GetBinaryNumber(int number)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var number = ReadInt();
        writer.WriteLine(GetBinaryNumber(number));

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}
