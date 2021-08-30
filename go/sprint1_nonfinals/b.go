package main

import (
	"fmt"
	"strconv"
)

func checkParity(a int, b int, c int) bool {
	// Ваше решение
}

func main() {
	a := readInt()
	b := readInt()
	c := readInt()
	if checkParity(a, b, c) {
		fmt.Println("WIN")
	} else {
		fmt.Println("FAIL")
	}
}

func readInt() int {
	var aString string
	fmt.Scan(&aString)
	a, _ := strconv.Atoi(aString)
	return a
}
