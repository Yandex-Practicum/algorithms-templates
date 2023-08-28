using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void MergeSort(List<int> array, int left, int right)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    public static List<int> Merge(List<int> array, int left, int mid, int right)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    #if !REMOTE_JUDGE
    public static void Main(string[] args)
    {
        var a = new List<int> { 1, 4, 9, 2, 10, 11 };
        var b = Merge(a, 0, 3, 6);
        var expectedMergeResult = new List<int> {1, 2, 4, 9, 10, 11};
        System.Console.WriteLine(b.SequenceEqual(expectedMergeResult));
        var c = new List<int> {1, 4, 2, 10, 1, 2};
        MergeSort(c, 0, 6);
        var expectedMergeSortResult = new List<int> {1, 1, 2, 2, 4, 10};
        System.Console.WriteLine(c.SequenceEqual(expectedMergeSortResult));
    }
    #endif
}
