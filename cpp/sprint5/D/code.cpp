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


bool Solution(const Node* root1, const Node* root2) {
    // Your code
    // “ヽ(´▽｀)ノ”
} 

void test() {

    Node node1({1, nullptr, nullptr});
    Node node2({2, nullptr, nullptr});
    Node node3({3, &node1, &node2});

    Node node4({1, nullptr, nullptr});
    Node node5({2, nullptr, nullptr});
    Node node6({3, &node4, &node5});
    assert(Solution(&node3, &node6));
}
