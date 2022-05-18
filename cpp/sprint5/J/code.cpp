/** Comment it before submitting 
struct Node {  
  Node* left;  
  Node* right;
  int value;
};
**/

#include "solution.h"
#include <cassert>

Node* insert(Node* root, int key) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

void test() {
    Node node1({nullptr, nullptr, 7});
    Node node2({&node1, nullptr, 8});
    Node node3({nullptr, &node2, 7});
    Node* newHead = insert(&node3, 6);
    assert(newHead->left->value == 6);
    assert(newHead == &node3);
}