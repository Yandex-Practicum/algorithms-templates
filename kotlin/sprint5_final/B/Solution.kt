/**
 * Comment it before submitting
 *
 * class Node(var left: Node?, var right: Node?, var value: Int)
 */

fun remove(root: Node?, key: Int): Node? {
    // Your code
    // ヽ(´▽`)/
}

fun test() {
    val node1 = Node(null, null, 2)
    val node2 = Node(node1, null, 3)
    val node3 = Node(null, node2, 1)
    val node4 = Node(null, null, 6)
    val node5 = Node(node4, null, 8)
    val node6 = Node(node5, null, 10)
    val node7 = Node(node3, node6, 5)
    val newHead = remove(node7, 10)
    assert(newHead!!.value == 5)
    assert(newHead.right == node5)
    assert(newHead.right!!.value == 8)
}
