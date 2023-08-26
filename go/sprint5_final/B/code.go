package main

type Node struct {
	value    int
	left   *Node
	right  *Node
}


func remove(node *Node, key int) *Node {
    // Your code
    // “ヽ(´▽｀)ノ”
}

func test() {
	node1 := Node{2, nil, nil}
    node2 := Node{3, &node1, nil}
    node3 := Node{1, nil, &node2}
    node4 := Node{6, nil, nil}
    node5 := Node{8, &node4, nil}
    node6 := Node{10, &node5, nil}
    node7 := Node{5, &node3, &node6}
    newHead := remove(&node7, 10)
    if newHead.value != 5 {
		panic("WA")
	}
    if newHead.right != &node5 {
		panic("WA")
	}
    if newHead.right.value != 8 {
		panic("WA")
	}
}