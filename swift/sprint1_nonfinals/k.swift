func readInts() -> [Int] {
    return readLine()!.split(separator: " ").compactMap { Int($0)! }
}

func readInt() -> Int {
    return Int(readLine()!)!
}

func print(_ result: [Int]) {
    print(result.compactMap { String($0)}.joined(separator: " "))
}

func getSum(_ numberList: [Int], _ k: Int) -> [Int] {
    // Здесь реализация вашего решения
}

func main() {
    let n = readInt()
    let numberList = readInts()
    let k = readInt()
    print(getSum(numberList, k))
}

main()
