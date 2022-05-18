/*
// закомментируйте перед отправкой
public class Node
{
    public int Value { get; set;}
    public Node Left { get; set;}
    public Node Right { get; set;}

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
*/

public class Solution
{
    public static bool Solve(Node root)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    private static void Test()
    {
        var node1 = new Node(3);
        var node2 = new Node(4);
        var node3 = new Node(4);
        var node4 = new Node(3);
        var node5 = new Node(2)
        {
            Left = node1,
            Right = node2,
        };

        var node6 = new Node(2)
        {
            Left = node3,
            Right = node4
        };

        var node7 = new Node(1)
        {
            Left = node5,
            Right = node6
        };

        Console.WriteLine(Solve(node7));
    }
}
