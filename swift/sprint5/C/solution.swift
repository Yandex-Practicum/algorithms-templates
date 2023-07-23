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
    var node1 = Node(3)
    var node2 = Node(4)
    var node3 = Node(4)
    var node4 = Node(3)
    var node5 = Node(2)
    node5.left = node1
    node5.right = node2
    var node6 = Node(2)
    node6.left = node3
    node6.right = node4
    var node7 = Node(1)
    node7.left = node5
    node7.right = node6
    assert(solution(node: node7))
}
