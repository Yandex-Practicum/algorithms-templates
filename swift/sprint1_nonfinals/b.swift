func checkParity(_ a : Int, _ b : Int, _ c : Int) ->Bool {
    // Здесь реализация вашего решения
}

func readInts() -> [Int] {
    return readLine()!.split(separator: " ").compactMap { Int($0)! }
}

func print(_ result: Bool) {
    print(result ? "WIN" : "FAIL")
}

func main() {
    let input = readInts()
    print(checkParity(input[0], input[1], input[2]))
}

main()
