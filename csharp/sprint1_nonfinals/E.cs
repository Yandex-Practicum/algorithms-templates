using System;
using System.IO;

public class E
{
    private static TextReader reader;
    private static TextWriter writer;

    private static string GetLongestWord(string text)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var textLength = ReadInt();
        var text = reader.ReadLine();
        var longestWord = GetLongestWord(text);

        writer.WriteLine(longestWord);
        writer.WriteLine(longestWord.Length);

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}
