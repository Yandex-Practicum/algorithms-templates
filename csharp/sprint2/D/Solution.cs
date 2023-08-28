#if !REMOTE_JUDGE
public class Node<TValue>
{
    public TValue Value { get; private set; }
    public Node<TValue> Next { get; set; }

    public Node(TValue value, Node<TValue> next)
    {
        Value = value;
        Next = next;
    }
}
#endif

public class Solution
{
    public static int Solve(Node<string> head, string item)
    {
        // Your code
        // ヽ(´▽`)/
    }

    #if !REMOTE_JUDGE
    private static void Main()
    {
        var node3 = new Node<string>("node3", null);
        var node2 = new Node<string>("node2", node3);
        var node1 = new Node<string>("node1", node2);
        var node0 = new Node<string>("node0", node1);
        var idx = Solution.Solve(node0, "node2");
        // result is : idx == 2
    }
    #endif
}

