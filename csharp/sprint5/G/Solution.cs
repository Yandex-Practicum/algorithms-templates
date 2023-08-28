#if !REMOTE_JUDGE
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
    public static int Solve(Node root)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    #if !REMOTE_JUDGE
    private static void Main()
    {
        var node1 = new Node(5);
        var node2 = new Node(1);
        var node3 = new Node(-3)
        {
            Left = node2,
            Right = node1,
        };

        var node4 = new Node(2);
        var node5 = new Node(2)
        {
            Left = node4,
            Right = node3
        };

        System.Console.WriteLine(Solve(node5) == 6);
    }
    #endif
}
