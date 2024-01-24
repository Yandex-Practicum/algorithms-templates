func readInts() -> [Int] {
    return readLine()!.split(separator: " ").compactMap { Int($0)! }
}

func readInt() -> Int {
    return Int(readLine()!)!
}

func getWeatherRandomness(_ temperatures: [Int]) -> Int{
    // Здесь реализация вашего решения
}

func main() {
    let n = readInt()
    let temperatures = readInts()
    print(getWeatherRandomness(temperatures))
}

main()
