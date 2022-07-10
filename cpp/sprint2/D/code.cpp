// ! Remove define before submitting !
#define local

#ifndef local
#include "solution.h"
#endif

#ifdef local
#include <cassert>
#include <string>
#endif



#ifdef local

struct Node {  
    std::string value;  
    Node* next;  
    Node(const std::string &value, Node* next) : value(value), next(next) {
        
    }
};
#endif


int solution(Node* head, const std::string& elem) {
    // Your code
    // ヽ(´▽`)/
}

#ifdef local
void test() {
    Node node3("node3", nullptr);
    Node node2("node2", &node3);
    Node node1("node1", &node2);
    Node node0("node0", &node1);
    int idx = solution(&node0, "node2");
    assert(idx == 2);
}

int main() {
    test();
}
#endif