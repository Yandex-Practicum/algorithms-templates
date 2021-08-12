from typing import List

def weather_randomness(weather_data: List[int]) -> int:
    # Здесь реализация вашего решения
    pass

def read_input() -> List[int]:
    n = int(input())
    weather_data = list(map(int, input().strip().split()))
    return weather_data

weather_data = read_input()
print(weather_randomness(weather_data))
