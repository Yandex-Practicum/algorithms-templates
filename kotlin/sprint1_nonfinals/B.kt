fun main() {
    val (a, b, c) = readInts()
    val ok = solve(a, b, c)
    if (ok) {
        println("WIN")
    } else {
        println("FAIL")
    }
}

private fun solve(a: Int, b: Int, c: Int): Boolean {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

private fun readStr() = readln()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() }
