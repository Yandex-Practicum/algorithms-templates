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

func printRange(root: Node?, from: Int, to: Int) {
    // Your code
    // ヽ(´▽`)/
}

func test() {
    var node1 = Node(2)
    var node2 = Node(1)
    node2.right = node1
    var node3 = Node(8)
    var node4 = Node(8)
    node4.right = node3
    var node5 = Node(9)
    node5.left = node4
    var node6 = Node(10)
    node6.left = node5
    var node7 = Node(5)
    node7.left = node2
    node7.right = node6
    printRange(root: node7, from: 2, to: 8);
    // expected output: 2 5 8 8
}
