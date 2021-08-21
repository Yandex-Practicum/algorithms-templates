from typing import List, Tuple

def get_neighbours(matrix: List[List[int]], row: int, column: int) -> List[int]:
    # Здесь реализация вашего решения
    pass

def read_input() -> Tuple[List[List[int]], int, int]:
    n = int(input())
    m = int(input())
    matrix = []
    for i in range(n):
        matrix.append(list(map(int, input().strip().split())))
    row = int(input())
    column = int(input())
    return matrix, row, column

matrix, row, column = read_input()
print(" ".join(map(str, get_neighbours(matrix, row, column))))
