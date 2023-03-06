private fun movingAverage(a: List<Int>, k: Int): List<Double> {
    // Your code
    // ヽ(´▽`)/
}

fun main() {
    val size = readInt()
    val a = readInts()
    val k = readInt()
    println(movingAverage(a, k).joinToString(" "))
}

private fun readStr() = readln()
private fun readInt() = readStr().toInt()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() }