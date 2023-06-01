/**
 * Comment it before submitting
 *
 * class Node(var left: Node?, var right: Node?, var value: Int, var size: Int)
 */

fun split(root: Node?, k: Int): List<Node?> {
    // Your code
    // “ヽ(´▽｀)ノ”
}


fun test() {
    val node1 = Node(null, null, 3, 1)
    val node2 = Node(null, node1, 2, 2)
    val node3 = Node(null, null, 8, 1)
    val node4 = Node(null, null, 11, 1)
    val node5 = Node(node3, node4, 10, 3)
    val node6 = Node(node2, node5, 5, 6)
    val res: List<Node?> = split(node6, 4)
    assert(res[0]!!.size == 4)
    assert(res[1]!!.size == 2)
}