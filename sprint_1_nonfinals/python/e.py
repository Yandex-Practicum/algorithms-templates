def get_longest_word(text: str) -> str:
    # Здесь реализация вашего решения
    pass

def read_input() -> str:
    _ = input()
    text = input().strip()
    return text

def print_result(result: str) -> None:
    print(result)
    print(len(result))

print_result(get_longest_word(read_input()))
