using System.Collections.Generic;

public class Solution
{
    public static int SiftDown(List<int> array, int idx)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    #if !REMOTE_JUDGE
    private static void Main()
    {
        var sample = new List<int> {-1, 12, 1, 8, 3, 4, 7};
        System.Console.WriteLine(SiftDown(sample, 2) == 5);
    }
    #endif
}
