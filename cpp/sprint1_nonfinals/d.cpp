#include <iostream>
#include <vector>

using namespace std;

int GetWeatherRandomness(const vector <int> &temperatures) {
	// Здесь реализация вашего решения

}

void print(int result) {
	cout << result << endl;
}

int main() {
	int n;
	cin >> n;
	vector <int> temperatures(n);
	for (int i = 0; i < n; ++i)
		cin >> temperatures[i];
	print(GetWeatherRandomness(temperatures));
}
