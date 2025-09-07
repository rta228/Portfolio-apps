#include <iostream>

using namespace std;

class Tabelka {
private:
	int max, przech;
	int* tab = new int[ 10 ];

public:
	void getData() {
		for (int i = 0; i <= sizeof(tab)+1; i++) {
			cout << "\nPodaj " << i + 1 << " element tablicy: ";
			cin >> tab[i];
		}
		przesuniecie();
	}

	void setData(int *tab, int max, int przech) {
		this->tab = tab;
		this->max = max;
		this->przech = przech;
	}

	int setMax() {
		max = tab[0];
		for (int i = 0; i <= sizeof(tab)+1; i++) {
			if (max < tab[i]) {
				max = tab[i];
				//cout << "\n### " << max << " ###\n"; Spr czemu to nie dzialalo
			}
		}
		return max;
	}

	int findMax() {
		max = setMax();
		for (int i = 0; i <= sizeof(tab) + 1; i++) {
			if (max == tab[i]) return i;
		}
	}

	void showData() {
		for (int i = 0; i <= sizeof(tab) + 1; i++) {
			cout << i << " element: " << tab[i] << endl;
		}
		wybor();
	}

	void przesuniecie() {
		for (int i = findMax(); i >= 0; i--) {
			tab[i] = tab[i - 1];
		}
		tab[0] = max;
		copy();
	}

	void copy() {
		int tab2[10];
		cout << "\n||| DRUGA TABLICA |||\n";
		for (int i = 0; i <= sizeof(tab) + 1; i++) {
			tab2[i] = tab[i];
			cout << i << " element tablic 2: " << tab2[i] << endl;
		}
	}

	int wybor() {
		cout << "\nCo chcesz zrobic?\n1. Utworz nowa tabele\n2. Zakoncz program\nTwoj wybor: ";
		cin >> przech;
		switch (przech) {
		case 1:
			przesuniecie();
			break;
		case 2:
			return 0;
			break;
		default:
			return 0;
			break;
		}
	}
};



int main() {
	Tabelka tabelka;
	tabelka.getData();

	return 0;
}