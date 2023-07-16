//   Comment it before submitting

//   open class Node {
//
//   public var value: String
//   public var next: Node?
//
//   public init(_ value: String) {
//     self.value = value
//     self.next = nil
//   }
// }
 
func solution(head: Node?, elem: String) -> Int {
    // Your code
    // ヽ(´▽`)/
    return -1;
}


func test() {
    let node3 = Node("node3")
    let node2 = Node("node2")
    node2.next = node3
    let node1 = Node("node1")
    node1.next = node2
    let node0 = Node("node0")
    node0.next = node1
    let idx = solution(head: node0, elem: "node2")
    assert(idx == 2)
}