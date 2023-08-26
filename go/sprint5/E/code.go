package main

// <template>
type Node struct {  
	value  int  
	left   *Node  
	right  *Node  
}
// <template>

func Solution(root *Node) bool {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func test() {
	node1 := Node{1, nil, nil}
    node2 := Node{4, nil, nil}
    node3 := Node{3, &node1, &node2}
    node4 := Node{8, nil, nil}
    node5 := Node{5, &node3, &node4}
	if !Solution(&node5) {
		panic("WA")
	}
	node2.value = 5
	if Solution(&node5) {
		panic("WA")
	}
}
