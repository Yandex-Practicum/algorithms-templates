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


bool Solution(const Node* root) {
    // Your code
    // “ヽ(´▽｀)ノ”
} 

void test() {
    Node node1({1, nullptr, nullptr});
    Node node2({-5, nullptr, nullptr});
    Node node3({3, &node1, &node2});
    Node node4({10, nullptr, nullptr});
    Node node5({2, &node3, &node4});
    assert(Solution(&node5));
}
