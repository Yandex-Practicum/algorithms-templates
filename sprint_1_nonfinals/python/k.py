from typing import List, Tuple

def add_two_numbers(digits: List[int], number: int) -> List[int]:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[List[int], int]:
    n = int(input())
    digits = list(map(int, input().strip().split()))
    number = int(input())
    return digits, number

digits, number = read_input()
print(" ".join(map(str, add_two_numbers(digits, number))))
