#include "solution.h"



/*
Comment it before submitting
struct Node {  
    std::string value;  
    Node* next;  
    Node(const std::string &value, Node* next);  
};
*/

Node* solution(Node* head, int idx) {
    // Your code
    // ヽ(´▽`)/
}
    
void test() {
    Node node3("node3", nullptr);
    Node node2("node2", &node3);
    Node node1("node1", &node2);
    Node node0("node0", &node1);
    Node* new_head = solution(&node0, 1);
    // result is : node0 -> node2 -> node3
}