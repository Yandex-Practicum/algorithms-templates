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
    Node node1({3, nullptr, nullptr});
    Node node2({4, nullptr, nullptr});
    Node node3({4, nullptr, nullptr});
    Node node4({3, nullptr, nullptr});
    Node node5({2, &node1, &node2});
    Node node6({2, &node3, &node4});
    Node node7({1, &node5, &node6});
    assert(Solution(&node7));
}
