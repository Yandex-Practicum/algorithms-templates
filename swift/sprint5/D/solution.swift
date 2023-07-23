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

func solution(node1: Node?, node2: Node?) -> Bool {
    // Your code
    // ヽ(´▽`)/
    return false
}


func test() {
    var node1 = Node(1)
    var node2 = Node(2)
    var node3 = Node(3)
    node3.left = node1
    node3.right = node2
    var node4 = Node(1)
    var node5 = Node(2)
    var node6 = Node(3)
    node6.left = node4
    node6.right = node5
    assert(solution(node1: node3, node2: node6))
}
