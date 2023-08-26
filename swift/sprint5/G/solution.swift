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

func solution(node: Node?) -> Int {
    // Your code
    // ヽ(´▽`)/
    return 0
}

func test() {
    var node1 = Node(5)
    var node2 = Node(1)
    var node3 = Node(-3)
    node3.left = node2
    node3.right = node1
    var node4 = Node(2)
    var node5 = Node(2)
    node5.left = node4
    node5.right = node3
    assert(solution(node: node5) == 6)
}
