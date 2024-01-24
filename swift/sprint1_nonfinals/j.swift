func readInt() -> Int {
    return Int(readLine()!)!
}

func print(_ result: [Int]) {
    print(result.compactMap { String($0)}.joined(separator: " "))
}

func factorize(_ number: Int) ->[Int] {
    // Здесь реализация вашего решения
}

func main() {
    let number = readInt()
    print(factorize(number))
}

main()
