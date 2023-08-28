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
    public static Node Remove(Node root, int key)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    #if !REMOTE_JUDGE
    public static void Main()
    {
        var node1 = new Node(2);
        var node2 = new Node(3)
        {
            Left = node1
        };

        var node3 = new Node(1)
        {
            Right = node2
        };

        var node4 = new Node(6);
        var node5 = new Node(8)
        {
            Left = node4
        };

        var node6 = new Node(10)
        {
            Left = node5
        };

        var node7 = new Node(5)
        {
            Left = node3,
            Right = node6
        };

        var newHead = Remove(node7, 10);

        Console.WriteLine(newHead.Value == 5);
        Console.WriteLine(newHead.Right == node5);
        Console.WriteLine(newHead.Right.Value == 8);
    }
    #endif
}
