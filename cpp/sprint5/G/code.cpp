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


int Solution(const Node* root) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

#ifndef REMOTE_JUDGE
void test() {
    Node node1({5, nullptr, nullptr});
    Node node2({1, nullptr, nullptr});
    Node node3({-3, &node2, &node1});
    Node node4({2, nullptr, nullptr});
    Node node5({2, &node4, &node3});
    assert(Solution(&node5) == 6);
}

int main() {
  test();
}
#endif