/** Comment it before submitting
struct Node {  
  int value;  
  const Node* left = nullptr;  
  const Node* right = nullptr;  
};
**/


#include "solution_tree.h"
#include <cassert>
#include <iostream>

using namespace std;


int Solution(const Node* root) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

void test() {
    Node node1({5, nullptr, nullptr});
    Node node2({1, nullptr, nullptr});
    Node node3({-3, &node2, &node1});
    Node node4({2, nullptr, nullptr});
    Node node5({2, &node4, &node3});
    assert(Solution(&node5) == 6);
}
