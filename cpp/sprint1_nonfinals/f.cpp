#include <iostream>
#include <string>

using namespace std;

bool IsPalindrome(const string &line) {
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
	string line;
	getline(cin, line);
	print(IsPalindrome(line));
}
