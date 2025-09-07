// Szyfr.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class SzyfrCezara {

    string tablicaMalychLiter = "abcdefghijklmnoprstuwxyz";
    string tablicaDuzychLiter = "ABCDEFGHIJKLMNOPRSTUWXYZ";
    int kluczCezara = 0;
    string ciagDoZaszyfrowania = "";

    string ciagZaszyfrowany = "";

    string ZaszyfrujDane(string doOdszyfrowania, int klucz) {
        int wielkoscWyrazu = doOdszyfrowania.length();
        int ileLiter = tablicaMalychLiter.length();
        int indeksPoZmianie = 0;
        for (int i = 0; i < wielkoscWyrazu; i++) {
            for (int j = 0; j < ileLiter; j++) {
                if (doOdszyfrowania[i] == tablicaMalychLiter[j]) {
                    if (j + klucz >= ileLiter) {
                        indeksPoZmianie = (j + klucz) % ileLiter;
                    }
                    else {
                        indeksPoZmianie = j + klucz;
                    }
                    doOdszyfrowania[i] = tablicaMalychLiter[indeksPoZmianie];
                    break;
                }
                else if (doOdszyfrowania[i] == tablicaDuzychLiter[j]) {
                    if (j + klucz >= ileLiter) {
                        indeksPoZmianie = (j + klucz) % ileLiter;
                    }
                    else {
                        indeksPoZmianie = j + klucz;
                    }
                    doOdszyfrowania[i] = tablicaDuzychLiter[indeksPoZmianie];
                    break;
                }
            }
        }
        return doOdszyfrowania;
    }

    string OdszyfrujDane(string doZaszyfrowania, int klucz) {
        int wielkoscWyrazu = doZaszyfrowania.length();
        int ileLiter = tablicaMalychLiter.length();
        int indeksPoZmianie = 0;
        for (int i = 0; i < wielkoscWyrazu; i++) {
            for (int j = 0; j < ileLiter; j++) {
                if (doZaszyfrowania[i] == tablicaMalychLiter[j]) {
                    if (j - klucz < 0) {
                        indeksPoZmianie = ileLiter + (j - klucz);
                    }
                    else {
                        indeksPoZmianie = j - klucz;
                    }
                    doZaszyfrowania[i] = tablicaMalychLiter[indeksPoZmianie];
                    break;
                }
                else if (doZaszyfrowania[i] == tablicaDuzychLiter[j]) {
                    if (j - klucz < 0) {
                        indeksPoZmianie = ileLiter + (j - klucz);
                    }
                    else {
                        indeksPoZmianie = j - klucz;
                    }
                    doZaszyfrowania[i] = tablicaDuzychLiter[indeksPoZmianie];
                    break;
                }
            }
        }
        return doZaszyfrowania;
    }

public:

    void WprowadzDane() {
        cout << "Podaj tekst do zaszyfrowania: "; cin >> ciagDoZaszyfrowania;
        cout << "Podaj klucz szyfru: "; cin >> kluczCezara;
    }

    void WypiszDane() {
        cout << "Bez zaszyfrowania: " << OdszyfrujDane(ZaszyfrujDane(ciagDoZaszyfrowania, kluczCezara), kluczCezara) << endl;
        cout << "Zaszyfrowany: " << ZaszyfrujDane(ciagDoZaszyfrowania, kluczCezara) << endl;
    }
};

int main(){
    setlocale(LC_CTYPE, "polish");
    SzyfrCezara szyfr1;
    szyfr1.WprowadzDane();
    szyfr1.WypiszDane();

    return 0;
}