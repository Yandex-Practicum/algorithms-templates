from typing import List

def get_weather_randomness(temperatures: List[int]) -> int:
    # Здесь реализация вашего решения
    pass

def read_input() -> List[int]:
    n = int(input())
    temperatures = list(map(int, input().strip().split()))
    return temperatures

temperatures = read_input()
print(get_weather_randomness(temperatures))
