#include <iostream>
#include <vector>

using namespace std;

vector <double> solve(vector <int> arr, int k) {
	// Здесь реализация вашего решения

}

void print(const vector <double> &result) {
	for (double x : result)
		cout << x << " ";
	cout << endl;
}

int main() {
	int n, k;
	cin >> n;
	vector <int> arr(n);
	for (int i = 0; i < n; ++i)
		cin >> arr[i];
	cin >> k;
	print(solve(arr, k));
}
