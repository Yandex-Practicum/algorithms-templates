#include <iostream>
#include <string>

using namespace std;

char GetExcessiveLetter(const string &shorter, const string &longer) {
	// Здесь реализация вашего решения

}

void print(char result) {
	cout << result << endl;
}

int main() {
	string shorter, longer;
	cin >> shorter >> longer;
	print(GetExcessiveLetter(shorter, longer));
}
