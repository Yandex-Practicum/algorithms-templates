package main


/**
Comment it before submitting
type Node struct {  
	value  int  
	left   *Node  
	right  *Node  
}
**/

func Solution(root *Node) int {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func test() {
	node1 := Node{2, nil, nil}
    node2 := Node{1, nil, nil}
    node3 := Node{3, &node1, &node2}
    node4 := Node{2, nil, nil}
    node5 := Node{1, &node4, &node3}
	if Solution(&node5) != 275 {
		panic("WA")
	}
}
