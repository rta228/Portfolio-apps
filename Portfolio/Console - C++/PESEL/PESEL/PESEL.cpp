// PESEL.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Pesel {
    string pesel = "05212803054";
public:
    void UstawianieDanych(string pPesel) {
        pesel = pPesel;
    }

    void WprowadzanieDanych() {
        cout << "Prosze wprowadzic swoj PESEL (11 cyfr): "; cin >> pesel;
    }

    bool SprawdzenieSumyKontrolnej(string pesel) {
        int wagaCyfr[10] = { 1,3,7,9,1,3,7,9,1,3 };
        int S = 0;
        int M = 0;
        int R = 0;
        for (int i = 0; i < 10; i++) {
            S += (pesel[i] - '0') * wagaCyfr[i];
        }
        M = S % 10;
        if (M == 0) {
            R = 0;
        }
        else {
            R = 10 - M;
        }

        if ((pesel[10] - '0') == R) {
            return true;
        }
        else {
            return false;
        }
    }
    /* **********************************************
        nazwa funkcji: SprawdzaniePlci 
        opis funkcji : Funkcja sprawdza czy przedostatni znak Peselu (cyfra oznaczajaca plec) jest podzielna przez 2 czy tez nie. Jesli jest podzielna przez 2 oznacza to ze pesel nalezy do kobiety w przeciwnym razie do mezczyzny
        parametry : string Pesel - ciag znakow przechowywujacy Pesel dla ktorego program ma sprawdzic plec
        zwracany typ i opis : char - typ znakowy opisujacy czy jestes 'K' kobieta czy tez 'M' mezczyzna
        autor : 05212803054
    *********************************************** */
    char SprawdzaniePlci(string pesel) {
        int pozycjaCyfryPlci = pesel.length() - 2;
        if (pesel[pozycjaCyfryPlci]%2==0) {
            return 'K';
        }
        else {
            return 'M';
        }
    }

    void WypiszDane() {
        bool czySumaKontrolnaJestPoprawna = SprawdzenieSumyKontrolnej(pesel);
        char plecZPeselu = SprawdzaniePlci(pesel);
        if (czySumaKontrolnaJestPoprawna) {
            cout << "Suma kontrolna jest poprawna" << endl;
        }
        else {
            cout << "Suma kontrolna nie jest poprawna" << endl;
        }

        if (plecZPeselu=='K') {
            cout << "KOBIETA" << endl;
        }
        else {
            cout << "MEZCZYZNA" << endl;
        }
    }
};

int main(){
    setlocale(LC_CTYPE, "polish");
    Pesel objekt1;
    objekt1.WprowadzanieDanych();
    objekt1.WypiszDane();
    return 0;
}
