package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func getNeighbours(matrix [][]int, row int, col int) []int {
	// Ваше решение
}

func main() {
	scanner := makeScanner()
	rows := readInt(scanner)
	cols := readInt(scanner)
	matrix := readMatrix(scanner, rows, cols)
	rowId := readInt(scanner)
	colId := readInt(scanner)
	neighbours := getNeighbours(matrix, rowId, colId)
	for _, elem := range neighbours {
		fmt.Print(elem)
		fmt.Print(" ")
	}
}

func makeScanner() *bufio.Scanner {
	const maxCapacity = 3 * 1024 * 1024
	buf := make([]byte, maxCapacity)
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Buffer(buf, maxCapacity)
	return scanner
}

func readArray(scanner *bufio.Scanner) []int {
	scanner.Scan()
	listString := strings.Split(scanner.Text(), " ")
	arr := make([]int, len(listString))
	for i := 0; i < len(listString); i++ {
		arr[i], _ = strconv.Atoi(listString[i])
	}
	return arr
}

func readInt(scanner *bufio.Scanner) int {
	scanner.Scan()
	stringInt := scanner.Text()
	res, _ := strconv.Atoi(stringInt)
	return res
}

func printArray(arr []int) {
	writer := bufio.NewWriter(os.Stdout)
	for i := 0; i < len(arr); i++ {
		writer.WriteString(strconv.Itoa(arr[i]))
		writer.WriteString(" ")
	}
	writer.Flush()
}

func readMatrix(scanner *bufio.Scanner, rows int, cols int) [][]int {
	matrix := make([][]int, rows)
	for i := 0; i < rows; i++ {
		matrix[i] = readArray(scanner)
	}
	return matrix
}
