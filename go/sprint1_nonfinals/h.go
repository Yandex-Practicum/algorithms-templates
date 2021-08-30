package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func getSum(firstNumber string, secondNumber string) string {
	// Ваше решение
}

func main() {
	scanner := makeScanner()
	firstNumber := readLine(scanner)
	secondNumber := readLine(scanner)
	sum := getSum(firstNumber, secondNumber)
	fmt.Println(sum)
}

func makeScanner() *bufio.Scanner {
	const maxCapacity = 3 * 1024 * 1024
	buf := make([]byte, maxCapacity)
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Buffer(buf, maxCapacity)
	return scanner
}

func readLine(scanner *bufio.Scanner) string {
	scanner.Scan()
	return scanner.Text()
}

func printArray(arr []int) {
	writer := bufio.NewWriter(os.Stdout)
	for i := 0; i < len(arr); i++ {
		writer.WriteString(strconv.Itoa(arr[i]))
		writer.WriteString(" ")
	}
	writer.Flush()
}
