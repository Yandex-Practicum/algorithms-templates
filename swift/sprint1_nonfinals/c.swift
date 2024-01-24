func getNeighbours(_ matrix: [[Int]], _ row: Int, _ col: Int) -> [Int] {
    // Здесь реализация вашего решения
}


func readInts() -> [Int] {
    return readLine()!.split(separator: " ").compactMap { Int($0)! }
}

func readInt() -> Int {
    return Int(readLine()!)!
}

func print(_ result: [Int]) {
    print(result.compactMap{ String($0) }.joined(separator: " "))
}

func main() {
    let n = readInt()
    let m = readInt()
    let matrix = (1...n).map{ _ in readInts() }
    let row = readInt()
    let col = readInt()
    print(getNeighbours(matrix, row, col))
}

main()
