// Pliki.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
using namespace std;

class Plik {
    int IloscLinijekPliku=0;
    string* imionaZPliku;
    int* wiekiZPliku;
    string* miastaZPliku;
    fstream plik;

    string tablicaMalychLiter = "abcdefghijklmnoprstuwxyz";
    string tablicaDuzychLiter = "ABCDEFGHIJKLMNOPRSTUWXYZ";
    int kluczCezara = 0;

    string ZaszyfrujDane(string doZaszyfrowania, int klucz) {
        int wielkoscWyrazu = doZaszyfrowania.length();
        int ileLiter = tablicaMalychLiter.length();
        int indeksPoZmianie = 0;
        for (int i = 0; i < wielkoscWyrazu; i++) {
            for (int j = 0; j < ileLiter; j++) {
                if (doZaszyfrowania[i] == tablicaMalychLiter[j]) {
                    if (j + klucz >= ileLiter) {
                        indeksPoZmianie = (j + klucz)% ileLiter;
                    }
                    else {
                        indeksPoZmianie = j + klucz;
                    }
                    doZaszyfrowania[i] = tablicaMalychLiter[indeksPoZmianie];
                    break;
                }
                else if (doZaszyfrowania[i] == tablicaDuzychLiter[j]) {
                    if (j + klucz >= ileLiter) {
                        indeksPoZmianie = (j + klucz) % ileLiter;
                    }
                    else {
                        indeksPoZmianie = j + klucz;
                    }
                    doZaszyfrowania[i] = tablicaDuzychLiter[indeksPoZmianie];
                    break;
                }
            }
        }
        return doZaszyfrowania;
    }

public:

    void WczytajDaneKlucza() {
        cout << "Podaj klucz: "; cin >> kluczCezara;
    }

    void PoliczIloscRekordowZPliku() {
        string pojedynczaLiniaPliku;
        plik.open("dane.txt", ios::in);
        if (plik.good() == true) {
            while (getline(plik,pojedynczaLiniaPliku)) {
                IloscLinijekPliku++;
                cout << IloscLinijekPliku;
            }
            imionaZPliku = new string[IloscLinijekPliku];
            wiekiZPliku = new int[IloscLinijekPliku];
            miastaZPliku = new string[IloscLinijekPliku];
        }
        plik.close();
    }

    void WczytajDaneZPliku() {
        string pojedynczaLinijkaPliku;
        int indeks = 0;
        plik.open("dane.txt", ios::in);
        if (plik.good() == true) {
            while (getline(plik, pojedynczaLinijkaPliku)) {
                istringstream linia(pojedynczaLinijkaPliku); // Pobieranie rekordu jeden po drugim i do tego potrzebujesz biblioteki sstream
                linia >> imionaZPliku[indeks] >> wiekiZPliku[indeks] >> miastaZPliku[indeks]; // Pobieranie rekordu jeden po drugim
                indeks++;
            }
        }
        plik.close();
    }

    void WypiszDane() {
        cout << "Dane z Pliku" << endl;
        cout << "Szyfr cezara - " << ZaszyfrujDane("Szyfr cezara", kluczCezara) << endl;
        for (int i = 0; i < IloscLinijekPliku; i++) {
            cout << "Imie: " << imionaZPliku[i] << " ,masz " << wiekiZPliku[i] << " lat i Mieszkasz w: " << miastaZPliku[i] << endl;
            cout << "Zaszyfrowane Imie: " << ZaszyfrujDane(imionaZPliku[i], kluczCezara) << ", Zaszyfrowane miasto: " << ZaszyfrujDane(miastaZPliku[i], kluczCezara) << endl;
            cout << endl;
        }
    }

    void ZapiszDaneDoPliku() {
        string imie;
        string wiek;
        string miasto;
        string pojedynczaLinijkaDoPliku;
        plik.open("dane.txt", ios::app | ios::out);
        if (plik.good() == true) {
            cout << "Podaj imie:"; cin >> imie;
            cout << "Podaj wiek:"; cin >> wiek;
            cout << "Podaj miasto:"; cin >> miasto;
            pojedynczaLinijkaDoPliku = "\n" + imie + " " + wiek + " " + miasto;
            plik << pojedynczaLinijkaDoPliku;
        }
        plik.close();
    }
};

int main(){
    setlocale(LC_CTYPE, "polish");

    Plik plik;
    plik.PoliczIloscRekordowZPliku();
    plik.WczytajDaneZPliku();
    plik.WczytajDaneKlucza();
    plik.WypiszDane();
    //plik.ZapiszDaneDoPliku();

    return 0;
}
