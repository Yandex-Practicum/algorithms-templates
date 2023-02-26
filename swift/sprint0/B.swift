func zip(_ a: Array<Int>, _ b: Array<Int>) -> Array<Int> {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func readInts() -> Array<Int> {
    return readLine()!.split(separator: " ").map { (x: Substring) -> Int in
        return Int(x)!
    }
}

func printArray(_ a: Array<Int>) {
    for element in a {
        print(element, terminator: " ")
    }
}

let size = Int(readLine()!)!
let a = readInts()
let b = readInts()
let zipped = zip(a, b)
printArray(zipped)
