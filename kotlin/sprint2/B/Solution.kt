
import kotlin.jvm.internal.Reflection.function


/**
 * Comment it before submitting
 *
 * class Node<V>(var value: V, var next: Node<V>?) {}
 */

fun solution(head: Node<String>?) {
    // Your code
    // ヽ(´▽`)/
}

fun test() {
    val node3 = Node("node3")
    val node2 = Node("node2", node3)
    val node1 = Node("node1", node2)
    val node0 = Node("node0", node1)
    solution(node0)
    /*
    Output is:
    node0
    node1
    node2
    node3
    */
}