/**
Comment it before submitting 
class Node { 
    constructor(value, left = null, right = null, size = 0) { 
        this.value = value; 
        this.left = left; 
        this.right = right; 
        this.size = size;
    } 
}
**/

function split(node, k) {
    // Your code
    // “ヽ(´▽｀)ノ”
    return [null, null];
}

function test() {
    const node1 = new Node(3, null, null, 1);
    const node2 = new Node(2, null, node1, 2);
    const node3 = new Node(8, null, null, 1);
    const node4 = new Node(11, null, null, 1);
    const node5 = new Node(10, node3, node4, 3);
    const node6 = new Node(5, node2, node5, 6);
    const res = split(node6, 4);

    console.assert(res[0].size === 4);
    console.assert(res[1].size === 2);
}