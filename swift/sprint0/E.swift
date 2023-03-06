func getTwoSumFast(_ a: [Int], _ target: Int) -> (Int, Int)? {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func readInts() -> [Int] {
    return readLine()!.split(separator: " ").map { (x: Substring) -> Int in
        return Int(x)!
    }
}


let size = Int(readLine()!)!
let a = readInts()
let target = Int(readLine()!)!
let pair = getTwoSumFast(a, target)
if (pair == nil) {
    print("None")
} else {
    print(pair!.0, pair!.1, terminator: " ")
}
