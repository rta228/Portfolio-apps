#include <iostream>

using namespace std;

int przesuniecie() {
	int n = 11;
	int x,przech;
	int tab[11];

	for (int i = 0; i < n-1; i++) {
		cout << "\nPodaj " << i+1 << " element tablicy: ";
		cin >> tab[i];
	}

	cout << "Podaj dodatkowy element tablicy: ";
	cin >> x;
	for (int i = n; i >0; i--) {
		tab[i] = tab[i - 1];
	}
	tab[0] = x;

	for (int i = 0; i < n; i++) {
		cout << i << " element: " << tab[i] << endl;
	}

	cout << "\nCo chcesz zrobic?\n1. Dodaj kolejny\n2. Utworz nowa tabele\n3. Zakoncz program";
	cin >> przech;
	switch (przech) {
	case 1:
		cout << "Podaj dodatkowy element tablicy: ";
		cin >> x;
		n++;
		for (int i = n; i > 0; i--) {
			tab[i] = tab[i - 1];
		}
		tab[0] = x;
		for (int i = 0; i < n; i++) {
			cout << i << " element: " << tab[i] << endl;
		}
		break;
	case 2:
		przesuniecie();
		break;
	case 3:
		return 0;
		break;
	default:
		return 0;
		break;
	}
}

int main() {
	przesuniecie();
	return 0;
}