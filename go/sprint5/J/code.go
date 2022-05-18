package main

/**
Comment it before submitting 
type Node struct { 
	value    int 
	left   *Node 
	right  *Node 
}
**/

func insert(root *Node, key int) *Node {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func test() {
	node1 := Node{7, nil, nil}
    node2 := Node{8, &node1, nil}
    node3 := Node{7, nil, &node2}
    newHead := insert(&node3, 6)
	if newHead != &node3 {
		panic("WA")
	}
	if newHead.left.value != 6 {
		panic("WA")
	}
}
