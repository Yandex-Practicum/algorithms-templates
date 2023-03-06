func getMovingAverage(_ a: [Int], _ window: Int) -> [Double] {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func readInts() -> [Int] {
    return readLine()!.split(separator: " ").map { (x: Substring) -> Int in
        return Int(x)!
    }
}

func printArray<T>(_ a: [T]) {
    for element in a {
        print(element, terminator: " ")
    }
}

let size = Int(readLine()!)!
let a = readInts()
let window = Int(readLine()!)!
let averages = getMovingAverage(a, window)
printArray(averages)
