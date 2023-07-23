/*
 Comment it before submitting

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
 */


func remove(root: Node?, key: Int) -> Node? {
    // Your code
    // ヽ(´▽`)/
    return root
}

func test() {
    var node1 = Node(2)
    var node2 = Node(3)
    node2.left = node1
    var node3 = Node(1)
    node3.right = node2
    var node4 = Node(6)
    var node5 = Node(8)
    node5.left = node4
    var node6 = Node(10)
    node6.left = node5
    var node7 = Node(5)
    node7.left = node3
    node7.right = node6
    var newHead = remove(root: node7, key: 10)
    assert(newHead!.value == 5)
    assert(newHead!.right === node5)
    assert(newHead!.right!.value == 8)
}
