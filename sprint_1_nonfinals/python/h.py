from typing import Tuple

def add_two_numbers(A: str, B: str) -> str:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[str, str]:
    A = input().strip()
    B = input().strip()
    return A, B

A, B = read_input()
print(add_two_numbers(A, B))
