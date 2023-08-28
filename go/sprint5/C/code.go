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
	node1 := Node{3, nil, nil}
    node2 := Node{4, nil, nil}
    node3 := Node{4, nil, nil}
    node4 := Node{3, nil, nil}
    node5 := Node{2, &node1, &node2}
    node6 := Node{2, &node3, &node4}
    node7 := Node{1, &node5, &node6}
	
	if (!Solution(&node7)) {
		panic("WA")
	}
}