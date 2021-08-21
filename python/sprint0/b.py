from typing import List, Tuple

def zipper(A: List[int], B: List[int]) -> List[int]:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[List[int], List[int]]:
    n = int(input())
    A = list(map(int, input().strip().split()))
    B = list(map(int, input().strip().split()))
    return A, B

A, B = read_input()
print(" ".join(map(str, zipper(A, B))))
