def two_sum(numbers, required_sum):
    # Здесь реализация вашего решения
    pass

n = int(input())
numbers = list(map(int, input().strip().split()))
required_sum = int(input())
result = two_sum(numbers, required_sum)
if result is None:
    print(None)
else:
    print(" ".join(map(str, result)))
