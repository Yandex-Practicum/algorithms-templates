#include <iostream>
#include <vector>

using namespace std;

vector <int> solve(int x) {
	// Здесь реализация вашего решения

}

void print(const vector <int> &result) {
	for (int x : result)
		cout << x << " ";
	cout << endl;
}

int main() {
	int x;
	cin >> x;
	print(solve(x));
}
