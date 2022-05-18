/*
Comment if before submitting
class Node<V> {  
    public V value;  
    public Node<V> next;  
 
    public Node(V value, Node<V> next) {  
        this.value = value;  
        this.next = next;  
    }  
}
*/

public class Solution {
    public static Node<String> solution(Node<String> head, int idx) {
        // Your code
        // ヽ(´▽`)/
    }

    private static void test() {
        Node<String> node3 = new Node<>("node3", null);
        Node<String> node2 = new Node<>("node2", node3);
        Node<String> node1 = new Node<>("node1", node2);
        Node<String> node0 = new Node<>("node0", node1);
        Node<String> newHead = solution(node0, 1);
        // result is : node0 -> node2 -> node3
    }
}
