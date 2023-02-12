fun main() {
    val number = readInt()
    val factorization = factorize(number)
    println(factorization.joinToString(" "))
}

private fun factorize(n: Int): List<Int> {
    TODO()
    // Your code
    // ヽ(´▽`)/
}

private fun readStr() = readln()
private fun readInt() = readStr().toInt()