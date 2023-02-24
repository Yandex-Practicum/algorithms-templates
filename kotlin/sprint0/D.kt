private fun getTwoSum(a: List<Int>, k: Int): Pair<Int, Int>? {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

fun main() {
    val size = readInt()
    val a = readInts()
    val k = readInt()
    val result = getTwoSum(a, k)
    if (result == null) {
        println("None")
    } else {
        println("${result.first} ${result.second}")
    }
}

private fun readStr() = readln()
private fun readInt() = readStr().toInt()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() }