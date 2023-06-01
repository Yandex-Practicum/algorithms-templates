fun main() {
    val n = readInt()
    val arr = readInts()
    val chaosFactor = getChaosFactor(n, arr)
    println(chaosFactor)
}

private fun getChaosFactor(n: Int, arr: List<Int>): Int {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

private fun readStr() = readln()
private fun readInt() = readStr().toInt()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() } // list of ints
