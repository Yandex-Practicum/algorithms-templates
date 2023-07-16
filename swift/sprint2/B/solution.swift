
/**
Comment it before submitting

open class Node {
   
   public var value: String
   public var next: Node?
   
   public init(_ value: String) {
     self.value = value
     self.next = nil
   }
 }
 **/

func solution(head: Node?) {
    // Your code
    // ヽ(´▽`)/
}


func test() {
    let node3 = Node("node3")
    let node2 = Node("node2")
    node2.next = node3
    let node1 = Node("node1")
    node1.next = node2
    let node0 = Node("node0")
    node0.next = node1
    solution(head: node0)
    /*
    Output is:
    node0
    node1
    node2
    node3
    */
}


