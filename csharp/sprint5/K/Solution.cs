using System.IO;

#if REMOTE_JUDGE
#else
public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
#endif

public class Solution
{
    public static void PrintRange(Node root, int left, int right, StreamWriter writer)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }
}
