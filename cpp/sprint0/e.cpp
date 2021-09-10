#include <iostream>
#include <vector>

using namespace std;

// Если ответ существует, верните вектор из двух элементов
// Если нет - то верните пустой вектор
vector <int> TwoSum(const vector <int> &sortedArr, int targetSum) {
	// Здесь реализация вашего решения

}

void print(const vector <int> &result) {
	if (result.size() != 2)
		cout << "None" << endl;
	else
		cout << result[0] << " " << result[1] << endl;
}

int main() {
	int n, targetSum;
	cin >> n;
	vector <int> sortedArr(n);
	for (int i = 0; i < n; ++i)
		cin >> sortedArr[i];
	cin >> targetSum;
	print(TwoSum(sortedArr, targetSum));
}
