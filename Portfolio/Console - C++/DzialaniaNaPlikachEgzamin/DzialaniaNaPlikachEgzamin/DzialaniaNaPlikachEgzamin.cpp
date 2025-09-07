// DzialaniaNaPlikachEgzamin.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class Albumy {
public:
	string* artysci;
	string* album;
	int* numerPiosenki;
	int* rokWydania;
	long* iloscPobran;
	fstream plik;
	int rozmiarTablic = 0;

	void LiczenieRekordow() {
		string pojedynczaLiniaPliku;
		plik.open("Data.txt", ios::in);
		if (plik.good() == true) {
			while (getline(plik, pojedynczaLiniaPliku)) {
				if (pojedynczaLiniaPliku == "") {
					rozmiarTablic++;
				}
				//cout << pojedynczaLiniaPliku << endl;
			}
			artysci = new string[rozmiarTablic];
			album = new string[rozmiarTablic];
			numerPiosenki = new int[rozmiarTablic];
			rokWydania = new int[rozmiarTablic];
			iloscPobran = new long[rozmiarTablic];
		}
		plik.close();
	}

	void WczytywanieDanychZPLiku() {
		string pojedynczaLiniaPliku;
		plik.open("Data.txt", ios::in);
		if (plik.good() == true) {
			int i = 0; //AKtualny rekord
			int numerPola = 0; //Kolumny rekordu
			while (getline(plik, pojedynczaLiniaPliku)) {
				if (pojedynczaLiniaPliku == "") {
					numerPola = 0; // Reset numeru pola na początku nowego rekordu
					i++;
					if (i == rozmiarTablic) {
						break;
					}
					continue; //Jesli "" to idziemy do kolejnego
				}
				switch (numerPola) {
				case 0:
					artysci[i] = pojedynczaLiniaPliku;
					break;
				case 1:
					album[i] = pojedynczaLiniaPliku;
					break;
				case 2:
					numerPiosenki[i] = stoi(pojedynczaLiniaPliku);
					break;
				case 3:
					rokWydania[i] = stoi(pojedynczaLiniaPliku);
					break;
				case 4:
					iloscPobran[i] = stoi(pojedynczaLiniaPliku);
					break;
				default:
					break;
				}
				numerPola++;
			}
		}
		plik.close();
	}

	void WypisanieRekordow() {
		for (int i = 0; i < rozmiarTablic - 1; i++) {
			cout << artysci[i] << endl;
			cout << album[i] << endl;
			cout << numerPiosenki[i] << endl;
			cout << rokWydania[i] << endl;
			cout << iloscPobran[i] << endl;
			cout << endl;
		}
		/*string pojedynczaLiniaPliku;
		plik.open("Data.txt", ios::in);
		if (plik.good() == true) {
			while (getline(plik, pojedynczaLiniaPliku)) {
				cout << pojedynczaLiniaPliku << endl;
			}
		}
		plik.close();*/
	}

	/*~Albumy() {
		delete artysci;
		delete album;
		delete numerPiosenki;
		delete rokWydania;
		delete iloscPobran;
	}*/
};

int main() {
	setlocale(LC_CTYPE, "polish");
	Albumy albumy;
	albumy.LiczenieRekordow();
	albumy.WczytywanieDanychZPLiku();
	albumy.WypisanieRekordow();
	return 0;
}
