def moving_average(data, window_size):
    # Здесь реализация вашего решения
    pass

n = int(input())
data = list(map(int, input().strip().split()))
window_size = int(input())
print(" ".join(map(str, moving_average(data, window_size))))
