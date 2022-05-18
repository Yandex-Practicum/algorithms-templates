#include "solution.h"

/*
Comment it before submitting
struct Node {  
    std::string value;  
    Node* next;  
    Node(const std::string &value, Node* next);  
};
*/

void solution(Node* head) {
    // Your code
    // ヽ(´▽`)/
}

void test() {
    Node node3("node3", nullptr);
    Node node2("node2", &node3);
    Node node1("node1", &node2);
    Node node0("node0", &node1);
    solution(&node0);
    /*
    Output is:
    node0
    node1
    node2
    node3
    */
}