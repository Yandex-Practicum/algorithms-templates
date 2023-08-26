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
	node2 := Node{-5, nil, nil}
	node3 := Node{3, &node1, &node2}
	node4 := Node{10, nil, nil}
	node5 := Node{2, &node3, &node4}
	if (!Solution(&node5)) {
		panic("WA")
	}
}
