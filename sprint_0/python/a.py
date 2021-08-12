from typing import Tuple

def add_two_numbers(A: int, B: int) -> int:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[int, int]:
    A = int(input())
    B = int(input())
    return A, B

A, B = read_input()
print(add_two_numbers(A, B))
