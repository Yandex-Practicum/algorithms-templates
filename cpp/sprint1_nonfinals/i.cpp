#include <iostream>

using namespace std;

bool IsPowerOfFour(int number) {
	// Здесь реализация вашего решения

}

void print(bool result) {
	if (result)
		cout << "True";
	else
		cout << "False";
	cout << endl;
}

int main() {
	int number;
	cin >> number;
	print(IsPowerOfFour(number));
}
