/** Comment it before submitting
struct Node {  
  int value;  
  const Node* left = nullptr;  
  const Node* right = nullptr;  
};  
 **/

#include "solution_tree.h"
#include <cassert>

using namespace std;

int Solution(const Node* root) {
    // Your code
    // “ヽ(´▽｀)ノ”
} 

void test() {
    Node node1({1, nullptr, nullptr});
    Node node2({4, nullptr, nullptr});
    Node node3({3, &node1, &node2});
    Node node4({8, nullptr, nullptr});
    Node node5({5, &node3, &node4});
    assert(Solution(&node5) == 3);
}