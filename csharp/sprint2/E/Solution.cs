#if !REMOTE_JUDGE
public class Node<TValue>
{
    public TValue Value { get; private set; }
    public Node<TValue> Next { get; set; }
    public Node<TValue> Prev { get; set; }

    public Node(TValue value, Node<TValue> next, Node<TValue> prev)
    {
        Value = value;
        Next = next;
        Prev = prev;
    }
}
#endif

public class Solution
{
    public static Node<string> Solve(Node<string> head)
    {
        // Your code
        // ヽ(´▽`)/
    }

    #if !REMOTE_JUDGE
    private static void Main()
    {
        var node3 = new Node<string>("node3", null, null);
        var node2 = new Node<string>("node2", node3, null);
        var node1 = new Node<string>("node1", node2, null);
        var node0 = new Node<string>("node0", node1, null);
        var newNode = Solution.Solve(node0);
        /*
        result is : newNode == node3
        node3.next == node2
        node2.next == node1
        node2.prev == node3
        node1.next == node0
        node1.prev == node2
        node0.prev == node1
        */
    }
    #endif
}
