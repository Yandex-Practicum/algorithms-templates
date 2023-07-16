//   Comment it before submitting

//   open class Node {
//
//   public var value: String
//   public var next: Node?
//   public var prev: Node?
//
//   public init(_ value: String) {
//     self.value = value
//     self.next = nil
//     self.prev = nil
//   }
// }
 
func solution(head: Node?) -> Node? {
    // Your code
    // ヽ(´▽`)/ 
    return nil
}


func test() {
    let node3 = Node("node3")
    let node2 = Node("node2")
    node3.prev = node2
    node2.next = node3
    let node1 = Node("node1")
    node2.prev = node1
    node1.next = node2
    let node0 = Node("node0")
    node0.next = node1
    node1.prev = node0
    let new_head = solution(head: node0);
    assert(new_head === node3);
    assert(node3.next === node2);
    assert(node2.next === node1);
    assert(node2.prev === node3);
    assert(node1.next === node0);
    assert(node1.prev === node2);
    assert(node0.prev === node1);
}