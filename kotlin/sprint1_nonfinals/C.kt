data class Matrix(val n: Int, val m: Int, val data: List<IntArray>)

fun main() {
    val matrix = readMatrix()
    val x = readln().toInt()
    val y = readln().toInt()
    val neighbours = getNeighbours(matrix, x, y)
    neighbours.forEach { print("$it ") }
}

private fun getNeighbours(matrix: Matrix, x: Int, y: Int): List<Int> {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

fun readMatrix(): Matrix {
    val n = readInt()
    val m = readInt()
    val matrix = buildList(n) {
        for (i in 0 until n) {
            add(readInts().toIntArray())
        }
    }
    return Matrix(n, m, matrix)
}


private fun readStr() = readln()
private fun readInt() = readStr().toInt()
private fun readStrings() = readStr().split(" ")
private fun readInts() = readStrings().map { it.toInt() } // list of ints
