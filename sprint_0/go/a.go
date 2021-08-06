package main

import (
	"fmt"
	"strconv"
)

func solve(a int, b int) int {
	// Ваше решени
}

func main() {

	a := readInt()
	b := readInt()
	fmt.Println(solve(a, b))
}

func readInt() int {
	var aString string
	fmt.Scan(&aString)
	a, _ := strconv.Atoi(aString)
	return a
}
