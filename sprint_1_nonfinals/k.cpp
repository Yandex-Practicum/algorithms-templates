#include <iostream>
#include <vector>

using namespace std;

vector <int> solve(vector <int> x, int k) {
	// Здесь реализация вашего решения

}

void print(const vector <int> &result) {
	for (int x : result)
		cout << x << " ";
	cout << endl;
}

int main() {
	int n;
	cin >> n;
	vector <int> x(n);
	for (int i = 0; i < n; ++i)
		cin >> x[i];
	int k;
	cin >> k;
	print(solve(x, k));
}
