def add_two_numbers(digits, number):
    # Здесь реализация вашего решения
    pass

n = int(input())
digits = list(map(int, input().strip().split()))
number = int(input())
print(" ".join(map(str, add_two_numbers(digits, number))))
