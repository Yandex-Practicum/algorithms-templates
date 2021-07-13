#include <iostream>
#include <string>

using namespace std;

string solve(string input) {
	// Здесь реализация вашего решения

}

void print(string result) {
	cout << result << endl << result.length() << endl;
}

int main() {
	int n;
	cin >> n;
	string s;
	getline(cin, s);
	getline(cin, s);
	print(solve(s));
}
