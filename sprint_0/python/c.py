from typing import List, Tuple

def moving_average(data: List[int], window_size: int) -> List[float]:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[List[int], int]:
    n = int(input())
    data = list(map(int, input().strip().split()))
    window_size = int(input())
    return data, window_size

data, window_size = read_input()
print(" ".join(map(str, moving_average(data, window_size))))
