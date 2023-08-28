#if !REMOTE_JUDGE
open class Node {
    
    public var value: Int
    public var left: Node?
    public var right: Node?
    public var size: Int
    
    public init(_ value: Int) {
        self.value = value
        self.right = nil
        self.left = nil
        self.size = 1
    }
}
#endif

func calcSize(node: Node?) -> Int {
    if node == nil {
        return 0
    }
    return 1 + getSize(node: node!.left) + getSize(node: node!.right)
}

func getSize(node: Node?) -> Int {
    if node == nil {
        return 0
    }
    return node!.size
}

func split(root: Node?, k: Int) -> (Node?, Node?) {
    // Your code
    // ヽ(´▽`)/
    return (nil, nil)
}

func test() {
    var node1 = Node(3)
    var node2 = Node(2)
    node2.right = node1
    node2.size = 2
    var node3 = Node(8)
    
    var node4 = Node(11)
    var node5 = Node(10)
    node5.left = node3
    node5.right = node4
    var node6 = Node(5)
    node6.left = node2
    node6.right = node5
    var (left, right) = split(root: node6, k: 4)
    assert(left!.size == 4)
    assert(right!.size == 2)
}
