#include <iostream>
#include <vector>

using namespace std;

vector <int> Factorize(int number) {
	// Здесь реализация вашего решения

}

void print(const vector <int> &result) {
	for (int x : result)
		cout << x << " ";
	cout << endl;
}

int main() {
	int number;
	cin >> number;
	print(Factorize(number));
}
