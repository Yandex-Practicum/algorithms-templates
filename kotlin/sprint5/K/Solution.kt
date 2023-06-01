import java.io.BufferedWriter
import java.io.IOException
import java.io.OutputStreamWriter

/**
 * Comment it before submitting
 *
 * class Node(var left: Node?, var right: Node?, var value: Int)
 */

@Throws(IOException::class)
fun printRange(root: Node?, L: Int, R: Int, writer: BufferedWriter) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

fun test() {
    val node1 = Node(null, null, 2)
    val node2 = Node(null, node1, 1)
    val node3 = Node(null, null, 8)
    val node4 = Node(null, node3, 8)
    val node5 = Node(node4, null, 9)
    val node6 = Node(node5, null, 10)
    val node7 = Node(node2, node6, 5)
    val writer = BufferedWriter(OutputStreamWriter(System.out))
    printRange(node7, 2, 8, writer)
    writer.flush()
    // expected output: 2 5 8 8
}
