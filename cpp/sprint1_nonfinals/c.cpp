#include <iostream>
#include <vector>

using namespace std;

vector <int> GetNeighbours(const vector <vector <int> > &matrix, int row, int col) {
	// Здесь реализация вашего решения

}

void print(const vector <int> &result) {
	for (int x : result)
		cout << x << " ";
	cout << endl;
}

int main() {
	int n, m;
	cin >> n >> m;
	vector <vector <int> > matrix(n, vector <int> (m));
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < m; ++j)
			cin >> matrix[i][j];
	int row, col;
	cin >> row >> col;
	print(GetNeighbours(matrix, row, col));
}
