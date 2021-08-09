def zipper(A, B):
    # Здесь реализация вашего решения
    pass

n = int(input())
A = list(map(int, input().strip().split()))
B = list(map(int, input().strip().split()))
print(" ".join(map(str, zipper(A, B))))
