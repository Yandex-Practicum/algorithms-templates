#include <iostream>
#include <vector>

using namespace std;

vector <int> GetSum(const vector <int> &numberList, int k) {
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
	vector <int> numberList(n);
	for (int i = 0; i < n; ++i)
		cin >> numberList[i];
	int k;
	cin >> k;
	print(GetSum(numberList, k));
}
