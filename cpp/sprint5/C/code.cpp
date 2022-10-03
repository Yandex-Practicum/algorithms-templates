#ifndef REMOTE_JUDGE
struct Node {  
  int value;  
  const Node* left = nullptr;  
  const Node* right = nullptr;
  Node(int value, Node* left, Node* right) : value(value), left(left), right(right) {}
};  
#endif

#ifdef REMOTE_JUDGE
#include "solution_tree.h"
#endif
#include <cmath>
#include <iostream>
#include <cassert>


using namespace std;


bool Solution(const Node* root) {
    // Your code
    // “ヽ(´▽｀)ノ”
} 

#ifndef REMOTE_JUDGE
void test() {
    Node node1({3, nullptr, nullptr});
    Node node2({4, nullptr, nullptr});
    Node node3({4, nullptr, nullptr});
    Node node4({3, nullptr, nullptr});
    Node node5({2, &node1, &node2});
    Node node6({2, &node3, &node4});
    Node node7({1, &node5, &node6});
    assert(Solution(&node7));
}


int main() {
  test();
}
#endif