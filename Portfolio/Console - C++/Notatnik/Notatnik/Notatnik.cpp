// Notatnik.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>

using namespace std;

class Notatka {
    static int licznik;
    int identyfikator;
protected:
    string tytulNotatki;
    string trescNotatki;

public:
    Notatka(string pTytulNotatki, string pTrescNotatki) {
        tytulNotatki = pTytulNotatki;
        trescNotatki = pTrescNotatki;
        licznik++;
        identyfikator = licznik;
    }

    void WyswietlDaneNotatki() {
        cout << "Tytul notatki: " << tytulNotatki << ", Tresc notatki: " << trescNotatki << endl;
    }

    void FunkcjaDiagnostycznaWypiszDane() {
        cout << licznik << " ; " << identyfikator << " ; " << tytulNotatki << " ; " << trescNotatki << endl;
    }
};

int Notatka::licznik = 0;

int main(){
    setlocale(LC_CTYPE, "polish");

    Notatka notatka1("To Do", "Idz se kupic poduszke");
    notatka1.WyswietlDaneNotatki();
    notatka1.FunkcjaDiagnostycznaWypiszDane();

    Notatka notatka2("Silownia", "KLATAAAAAAAAAAAAAA");
    notatka2.WyswietlDaneNotatki();
    notatka2.FunkcjaDiagnostycznaWypiszDane();

    return 0;
}
