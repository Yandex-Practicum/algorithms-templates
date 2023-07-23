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

func solution(node: Node?) -> Bool {
    // Your code
    // ヽ(´▽`)/
    return false
}


func test() {
    var node1 = Node(1)
    var node2 = Node(4)
    var node3 = Node(3)
    node3.left = node1
    node3.right = node2
    var node4 = Node(8)
    var node5 = Node(5)
    node5.left = node3
    node5.right = node4
    assert(solution(node: node5))
    node2.value = 5
    assert(!solution(node: node5))
}
