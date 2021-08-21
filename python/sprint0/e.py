from typing import List, Tuple, Optional

def two_sum_fast(numbers: List[int], required_sum: int) -> Optional[Tuple[int, int]]:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[List[int], int]:
    n = int(input())
    numbers = list(map(int, input().strip().split()))
    required_sum = int(input())
    return numbers, required_sum

def print_result(result: Optional[Tuple[int, int]]) -> None:
    if result is None:
        print(None)
    else:
        print(" ".join(map(str, result)))

numbers, required_sum = read_input()
print_result(two_sum_fast(numbers, required_sum))
