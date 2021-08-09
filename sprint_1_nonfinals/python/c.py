def get_neighbours(matrix, row, column):
    # Здесь реализация вашего решения
    pass

n = int(input())
m = int(input())
matrix = []
for i in range(n):
    matrix.append(list(map(int, input().strip().split())))
row = int(input())
column = int(input())
print(" ".join(map(str, get_neighbours(matrix, row, column))))
