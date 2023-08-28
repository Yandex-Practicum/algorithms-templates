if (process.env.REMOTE_JUDGE !== 'true') {
    class CNode {
        constructor(value, left = null, right = null) {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}

function solution(root1, root2) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

function test() {
    var node1 = new CNode(1,  null,  null);
    var node2 = new CNode(2,  null,  null);
    var node3 = new CNode(3,  node1,  node2);

    var node4 = new CNode(1,  null,  null);
    var node5 = new CNode(2,  null,  null);
    var node6 = new CNode(3,  node4,  node5);
    
    console.assert(solution(node3, node6));
}