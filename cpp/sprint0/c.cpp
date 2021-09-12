#include <iostream>
#include <vector>

using namespace std;

vector <double> MovingAverage(const vector <int> &arr, int windowSize) {
	// Здесь реализация вашего решения

}

void print(const vector <double> &result) {
	for (double x : result)
		cout << x << " ";
	cout << endl;
}

int main() {
	int n, windowSize;
	cin >> n;
	vector <int> arr(n);
	for (int i = 0; i < n; ++i)
		cin >> arr[i];
	cin >> windowSize;
	print(MovingAverage(arr, windowSize));
}
