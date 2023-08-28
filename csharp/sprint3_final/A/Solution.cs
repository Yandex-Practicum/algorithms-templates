using System;
using System.Collections.Generic;

public class Solution
{
    public static int BrokenSearch(List<int> array, int el)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    #if !REMOTE_JUDGE
    private static void Main()
    {
        var arr = new List<int> {19, 21, 100, 101, 1, 4, 5, 7, 12};
        Console.WriteLine(BrokenSearch(arr, 5) == 6);
    }
    #endif
}
