#include <iostream>
#include <string>

using namespace std;

string GetLongestWord(string line) {
	// Здесь реализация вашего решения

}

void print(string result) {
	cout << result << endl << result.length() << endl;
}

int main() {
	int n;
	cin >> n;
	string line;
	getline(cin, line);
	getline(cin, line);
	print(GetLongestWord(line));
}
