package main

import (
	"fmt"
	"strconv"
)

func getSum(a int, b int) int {
	// Ваше решение
}

func main() {
	a := readInt()
	b := readInt()
	fmt.Println(getSum(a, b))
}

func readInt() int {
	var aString string
	fmt.Scan(&aString)
	a, _ := strconv.Atoi(aString)
	return a
}
