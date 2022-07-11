public class Solution {
    public static boolean treeSolution(Node head1, Node head2) {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    /** Comment it before submitting 
    private static class Node {
        int value;  
        Node left;  
        Node right;  
    
        Node(int value) {  
            this.value = value;
            this.left = null;
            this.right = null;
        }

        Node(int value, Node left, Node right) {  
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
    **/
    
    private static void test() {
        Node node1 = new Node(1,  null,  null);
        Node node2 = new Node(2,  null,  null);
        Node node3 = new Node(3,  node1,  node2);
        Node node4 = new Node(1,  null,  null);
        Node node5 = new Node(2,  null,  null);
        Node node6 = new Node(3,  node4,  node5);
        assert treeSolution(node3, node6);
    }
}
