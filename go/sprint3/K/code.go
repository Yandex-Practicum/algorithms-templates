package main

import	"reflect"


func merge_sort(arr []int, lf int, rg int) {
	// Your code
	// “ヽ(´▽｀)ノ”
}

func merge(arr []int, left int, mid int, right int) (result []int) {
	// Your code
	// “ヽ(´▽｀)ノ”
}

func main() {
	a := []int{1, 4, 9, 2, 10, 11}
	b := merge(a, 0, 3, 6)
	expected := []int{1, 2, 4, 9, 10, 11}
	if !reflect.DeepEqual(b, expected) {
		panic("WA. Merge")
	}

	c := []int{1, 4, 2, 10, 1, 2}
	merge_sort(c, 0, 6)
	expected = []int{1, 1, 2, 2, 4, 10}
	if !reflect.DeepEqual(c, expected) {
		panic("WA. MergeSort")
	}
}
