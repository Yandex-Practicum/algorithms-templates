fun merge(arr: IntArray, left: Int, mid: Int, right: Int): IntArray {
    // Your code
    // ヽ(´▽`)/
}

fun merge_sort(arr: IntArray, left: Int, right: Int) {
    // Your code
    // ヽ(´▽`)/
}

fun test() {
    val a = intArrayOf(1, 4, 9, 2, 10, 11)
    val b: IntArray = merge(a, 0, 3, 6)
    val expected = intArrayOf(1, 2, 4, 9, 10, 11)
    assert(b.contentEquals(expected))
    val c = intArrayOf(1, 4, 2, 10, 1, 2)
    merge_sort(c, 0, 6)
    val expected2 = intArrayOf(1, 1, 2, 2, 4, 10)
    assert(c.contentEquals(expected2))
}