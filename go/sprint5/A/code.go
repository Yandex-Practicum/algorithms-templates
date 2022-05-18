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
	node1 := Node{1, nil, nil}
	node2 := Node{-5, nil, nil}
	node3 := Node{3, &node1, &node2}
	node4 := Node{2, &node3, nil}
	if Solution(&node4) != 3 {
		panic("WA")
	}
}
