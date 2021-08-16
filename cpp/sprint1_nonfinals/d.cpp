#include <iostream>
#include <vector>

using namespace std;

int solve(vector <int> arr) {
	// Здесь реализация вашего решения

}

void print(int result) {
	cout << result << endl;
}

int main() {
	int n;
	cin >> n;
	vector <int> arr(n);
	for (int i = 0; i < n; ++i)
		cin >> arr[i];
	print(solve(arr));
}
