package main

/**
Comment it before submitting
type Node struct { 
	value    int 
	left   *Node 
	right  *Node 
	size     int
}
**/

func split(node *Node, k int) (*Node, *Node) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func test() {
	node1 := &Node{3, nil, nil, 1}
    node2 := &Node{2, nil, node1, 2}
    node3 := &Node{8, nil, nil, 1}
    node4 := &Node{11, nil, nil, 1}
    node5 := &Node{10, node3, node4, 3}
    node6 := &Node{5, node2, node5, 6}
    left, right := split(node6, 4);
    if left.size != 4 {
		panic("WA")
	}
	if right.size != 2 {
		panic("WA")
	}
}