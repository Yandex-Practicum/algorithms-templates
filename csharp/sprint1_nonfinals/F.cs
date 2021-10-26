using System;
using System.IO;

public class F
{
    private static TextReader reader;
    private static TextWriter writer;

    private static bool IsPalindrome(string text)
    {
        // Ваше решение
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var text = reader.ReadLine();

        if (IsPalindrome(text))
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
}
