private fun zip(a: List<Int>, b: List<Int>): List<Int> {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

fun main() {
    val size = readInt()
    val a = readInts()
    val b = readInts()
    println(zip(a, b).joinToString(" "))
}

private fun readStr() = readln()
private fun readInt() = readStr().toInt()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() }