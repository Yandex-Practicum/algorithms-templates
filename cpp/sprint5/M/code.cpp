// ! Remove define before submitting !
#define local

#include <vector>
#include <cassert>
#ifndef local
#include "solution.h"
#endif


int siftUp(std::vector<int>& heap, int idx) {
    // Your code
    // “ヽ(´▽｀)ノ”
}

#ifdef local
void test() {
    std::vector<int> sample = {-1, 12, 6, 8, 3, 15, 7};
    assert(siftUp(sample, 5) == 1);
}


int main() {
    test();
}
#endif