// DzialanieNaPlikach.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class DzialanieNaPlikach {
public:
    fstream plik; //ULTRA WAZNE plik na ktorym dzialamy musi byc tam gdzie jest plik c++
    int iloscLinijemPliku=0;
    float sredniaWartosciZPliku=0;
    string produtkDoSzukania;
    string produktDoDodania;
    string iloscPorduktuDoDodania;

    void OdczytPliku() {
        iloscLinijemPliku = 0;
        plik.open("dane.txt", ios::in); // Trzeba zapamietac te ios::in - umozliwia odczyt pliku
        string pojedynczaLinijka;
        if (plik.good() == true) { //Jesli plik istnieje to dzialamy
            while (getline(plik, pojedynczaLinijka)) { //Pobieramy kazda linijke tekstu
                cout << pojedynczaLinijka << endl;
                if (produtkDoSzukania == pojedynczaLinijka) {
                    cout << "\nSlowo: " << produtkDoSzukania << " jest w linijce: " << iloscLinijemPliku << endl;
                }
                iloscLinijemPliku++;
            }
            cout << "Ilosc linijek w pliku: " << iloscLinijemPliku  << endl;
        }
        plik.close();
    }

    void ModyfikacjaPliku() {
        plik.open("dane.txt", ios::app | ios::out); // Trzeba zapamietac te ios::app | ios::out - umozliwia modyfikacje i zapis pliku
        if (plik.good() == true){ //Jesli plik istnieje to dzialamy
            produktDoDodania = "\n" + produktDoDodania + ", " + iloscPorduktuDoDodania;
            plik << produktDoDodania; // Metoda dodania na koniec pliku jest mamy ios::app
            cout << "Produkt zostal dodany" << endl;
        }
        plik.close();
    }

        /* ************************************************
        nazwa:    WprowadzanieDanych 
        opis : Metoda po stosownym komunikacie prosi uzytkownika o wpisanie danych z klawiatury a nastepnie te dany przypisuje do pol klasy
        parametry : brak
        zwracany typ i opis : brak
        autor : 05212803054
        *********************************************** */
    void WprowadzanieDanych() {
        cout << "Prosze podac produkt ktorrego szukasz: "; cin >> produtkDoSzukania;
        cout << "Prosze wprowadzic nowy produkt: "; cin >> produktDoDodania;
        cout << "Prosze wprowadzic ilosc nowego produktu: "; cin >> iloscPorduktuDoDodania;
    }
};

int main()
{
    setlocale(LC_CTYPE, "polish");

    DzialanieNaPlikach obiekt1;
    obiekt1.WprowadzanieDanych();
    obiekt1.OdczytPliku();
    obiekt1.ModyfikacjaPliku();
    obiekt1.OdczytPliku();

    return 0;
}
