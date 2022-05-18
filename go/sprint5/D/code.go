package main

/**
Comment it before submitting
type Node struct {  
	value  int  
	left   *Node  
	right  *Node  
}
**/

func Solution(root1 *Node, root2 *Node) bool {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func test() {
	node1 := Node{1, nil, nil}
    node2 := Node{2, nil, nil}
    node3 := Node{3, &node1, &node2}
    node4 := Node{1, nil, nil}
    node5 := Node{2, nil, nil}
    node6 := Node{3, &node4, &node5}
	
	if (!Solution(&node3, &node6)) {
		panic("WA")
	}
}