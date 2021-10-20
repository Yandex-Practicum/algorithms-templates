using System;
using System.IO;

public class I
{
    private static TextReader reader;
    private static TextWriter writer;

    private static bool IsPowerOfFour(int n)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        if (IsPowerOfFour(n))
        {
            writer.WriteLine("True");
        }
        else
        {
            writer.WriteLine("False");
        }

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}
