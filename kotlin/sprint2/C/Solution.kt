// <template>
class Node<V>(var value: V, var next: Node<V>?) {}
// <template>

fun solution(head: Node<String>?, pos: Int): Node<String>? {
    // Your code
    // ヽ(´▽`)/
}

fun test() {
    val node3 = Node("node3", null)
    val node2 = Node("node2", node3)
    val node1 = Node("node1", node2)
    val node0 = Node("node0", node1)
    val newHead = solution(node0, 1)
    assert(newHead === node0)
    assert(newHead?.next === node2)
    assert(newHead?.next?.next === node3)
    assert(newHead?.next?.next?.next == null)
    // result is : node0 -> node2 -> node3
}