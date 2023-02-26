func getMovingAverage(_ a: Array<Int>, _ window: Int) -> Array<Double> {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func readInts() -> Array<Int> {
    return readLine()!.split(separator: " ").map { (x: Substring) -> Int in
        return Int(x)!
    }
}

func printArray<T>(_ a: Array<T>) {
    for element in a {
        print(element, terminator: " ")
    }
}

let size = Int(readLine()!)!
let a = readInts()
let window = Int(readLine()!)!
let averages = getMovingAverage(a, window)
printArray(averages)
