#include <iostream>
#include <vector>

using namespace std;

vector <int> solve(vector <int> A, vector <int> B) {
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
	vector <int> A(n), B(n);
	for (int i = 0; i < n; ++i)
		cin >> A[i];
	for (int i = 0; i < n; ++i)
		cin >> B[i];
	print(solve(A, B));
}
