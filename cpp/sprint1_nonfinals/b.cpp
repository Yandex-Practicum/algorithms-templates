#include <iostream>

using namespace std;

bool CheckParity(int a, int b, int c) {
	// Здесь реализация вашего решения

}

void print(bool result) {
	if (result)
		cout << "WIN" << endl;
	else
		cout << "FAIL" << endl;
}

int main() {
	int a, b, c;
	cin >> a >> b >> c;
	print(CheckParity(a, b, c));
}
