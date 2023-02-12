fun main() {
    val n = readInt()
    val digits = readInts()
    val k = readInt()
    val result = longAdd(digits, k)
    println(result.joinToString(" "))
}

private fun longAdd(digits: List<Int>, k: Int): List<Int> {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

private fun readStr() = readln()
private fun readInt() = readStr().toInt()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() }
