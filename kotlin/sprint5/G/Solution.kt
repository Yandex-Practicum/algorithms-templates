// <template>
class Node {
    var value: Int
    var left: Node?
    var right: Node?

    constructor(value: Int) {
        this.value = value
        right = null
        left = null
    }

    constructor(value: Int, left: Node?, right: Node?) {
        this.value = value
        this.left = left
        this.right = right
    }
}
// <template>

fun treeSolution(head: Node?): Int {
    // Your code
    // “ヽ(´▽｀)ノ”
}


private fun test() {
    val node1 = Node(5, null, null)
    val node2 = Node(1, null, null)
    val node3 = Node(-3, node2, node1)
    val node4 = Node(2, null, null)
    val node5 = Node(2, node4, node3)
    assert(treeSolution(node5) == 6)
}