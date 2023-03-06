func zip(_ a: [Int], _ b: [Int]) -> [Int] {
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
let b = readInts()
let zipped = zip(a, b)
printArray(zipped)
