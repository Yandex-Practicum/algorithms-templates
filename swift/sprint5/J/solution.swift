#if !REMOTE_JUDGE
open class Node {

    public var value: Int
    public var left: Node?
    public var right: Node?

    public init(_ value: Int) {
        self.value = value
        self.right = nil
        self.left = nil
    }
}
#endif

func insert(root: Node, newValue: Int) -> Node {
    // Your code
    // ヽ(´▽`)/
    return root
}

func test() {
    var node1 = Node(7)
    var node2 = Node(8)
    node2.left = node1
    var node3 = Node(7)
    node3.right = node2
    var newHead = insert(root: node3, newValue: 6)
    assert(newHead === node3)
    assert(newHead.left!.value == 6)
}
