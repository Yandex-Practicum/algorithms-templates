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
    var node1 = Node(1)
    var node2 = Node(-5)
    var node3 = Node(3)
    node3.left = node1
    node3.right = node2
    var node4 = Node(2)
    node4.left = node3
    assert(solution(node: node4) == 3)
}
