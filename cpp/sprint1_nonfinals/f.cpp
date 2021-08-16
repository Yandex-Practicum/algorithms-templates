#include <iostream>
#include <string>

using namespace std;

bool solve(string input) {
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
	string input;
	getline(cin, input);
	print(solve(input));
}
