fun main() {
    val (a, x, b, c) = readInts()
    println(calc(a, b, c, x))
}

private fun calc(a: Int, b: Int, c: Int, x: Int): Int {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

private fun readStr() = readln()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() }
