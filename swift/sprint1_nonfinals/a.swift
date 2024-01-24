func readInts() -> [Int] {
    return readLine()!.split(separator: " ").compactMap { Int($0)! }
}


func evaluateFunction(_ a : Int, _ b : Int, _ c : Int, _ x : Int) -> Int {
    // Здесь реализация вашего решения
}

func main() {
    let input = readInts()
    print(evaluateFunction(input[0], input[2], input[3], input[1]))
}
main()
