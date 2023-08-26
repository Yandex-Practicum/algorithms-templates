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
    public static bool Solve(Node left, Node right)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    private static void Test()
    {
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3)
        {
            Left = node1,
            Right = node2
        };

        var node4 = new Node(1);
        var node5 = new Node(2);
        var node6 = new Node(3)
        {
            Left = node4,
            Right = node5
        };

        Console.WriteLine(Solve(node3, node6));
    }
}
