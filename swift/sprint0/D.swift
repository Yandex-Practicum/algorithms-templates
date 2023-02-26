
func getTwoSum(_ a: Array<Int>, _ target: Int) -> (Int, Int)? {
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
let target = Int(readLine()!)!
let pair = getTwoSum(a, target)
if (pair == nil) {
    print("None")
} else {
    print(pair!.0, pair!.1, terminator: " ")
}

