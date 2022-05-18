/** Comment it before submitting 
struct Node {  
  Node* left;  
  Node* right;
  int value;
  int size;
};
**/

#include "solution.h"
#include <cassert>
#include <utility>

std::pair<Node*, Node*> split(Node* root, int k) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

void test() {
    Node node1({nullptr, nullptr, 3, 1});
    Node node2({nullptr, &node1, 2, 2});
    Node node3({nullptr, nullptr, 8, 1});
    Node node4({nullptr, nullptr, 11, 1});
    Node node5({&node3, &node4, 10, 3});
    Node node6({&node2, &node5, 5, 6});
    std::pair<Node*, Node*> res = split(&node6, 4);
    assert(res.first->size == 4);
    assert(res.second->size == 2);
}
