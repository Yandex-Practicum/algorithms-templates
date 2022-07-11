using System.Collections.Generic;

/*
// закомментируйте перед отправкой
public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public int Size { get; set; }

    public Node(int value, int size)
    {
        Value = value;
        Size = size;
        Left = null;
        Right = null;
    }
}
*/
public class Solution
{
    public static List<Node> Split(Node root, int k)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    public static void Test()
    {
        var node1 = new Node(3, 1);
        var node2 = new Node(2, 2)
        {
            Right = node1
        };

        var node3 = new Node(8, 1);
        var node4 = new Node(11, 1);
        var node5 = new Node( 10, 3)
        {
            Left = node3,
            Right = node4
        };

        var node6 = new Node(5, 6)
        {
            Left = node2,
            Right = node5
        };

        var res = Split(node6, 4);

        Console.WriteLine(res[0].Size == 4);
        Console.WriteLine(res[1].Size == 2);
    }
}
