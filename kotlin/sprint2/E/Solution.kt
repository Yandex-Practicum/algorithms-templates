/**
 * Comment it before submitting
 *
 * class Node<V> {
 *     var value: V
 *     var next: Node<V>?
 *     var prev: Node<V>?
 *
 *     constructor(value: V) {
 *         this.value = value
 *         next = null
 *         prev = null
 *     }
 * }
 */


fun solution(head: Node<String>?): Node<String>? {
    // Your code
    // ヽ(´▽`)/
}


fun test() {
    val node3 = Node("node3", null, null)
    val node2 = Node("node2", node3, null)
    val node1 = Node("node1", node2, null)
    val node0 = Node("node0", node1, null)
    node1.prev = node0
    node2.prev = node1
    node3.prev = node2
    val newNode = solution(node0)
    assert(newNode === node3)
    assert(node3.next === node2)
    assert(node2.next === node1)
    assert(node2.prev === node3)
    assert(node1.next === node0)
    assert(node1.prev === node2)
    assert(node0.prev === node1)
}