
func merge_sort(arr: inout [Int]) {
    // Your code
    // ヽ(´▽`)/
}

func merge(a: [Int], b: [Int]) -> [Int] {
    // Your code
    // ヽ(´▽`)/
    return [1, 3, 4]
}

func test () {
    var a: [Int] = [1, 4, 9]
    var b: [Int] = [2, 10, 11]
    var c = merge(a: a, b: b);
    var expected: [Int] = [1, 2, 4, 9, 10, 11];
    assert(c == expected);
    var d: [Int] = [1, 4, 2, 10, 1, 2]
    var sorted = [1, 1, 2, 2, 4, 10]
    merge_sort(arr: &d);
    assert(d == sorted);
}
