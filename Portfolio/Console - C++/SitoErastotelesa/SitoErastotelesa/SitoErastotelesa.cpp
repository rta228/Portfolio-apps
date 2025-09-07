// SitoErastotelesa.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.

#include <iostream>
using namespace std;

class SitoErastotelesa {
public:
    bool tablicaLiczbDoPrzeszukania[101];
    int wielkoscTablicy = 101;

    /* *******************************************************
   nazwa funkcji:       WypelnijTabliceDanymi
   parametry wejściowe: brak
   wartość zwracana:    brak
   informacje:          Funkcja przechodzi po kazdym elemencie tablicy z wylaczeniem 0 i 1 a nastepnie przypiosuje im wartosc logiczna TRUE
   autor:               05212803054
   **************************************************** */
    void WypelnijTabliceDanymi(bool tablicaWartosci[]) {
        for (int i = 2; i < wielkoscTablicy; i++) {
            tablicaWartosci[i] = true;
        }
    }
    /* ******************************************************* 
    nazwa funkcji:       WyszukajLiczbyPierwsze
    parametry wejściowe: tablicaWartosci - Przechowuje 100 wartosci logicznych Wszystkie TRUE, ktore nastepnie w ciagu wykonywania funkcji beda zmienialy sie kolejno (true) - liczba pierwsza, (false) - liczby nie pierwsze dla liczby ktora jest indeksem danej wartosci
    wartość zwracana:    Nic nie zwraca
    informacje:          Funkcja przechodzi po kazdym indeksie tablicy od 2 do 100 mnozonym przez liczby od 2 do pierwiastka z wielkosciTablicy a nastepnie na tych indeksach ustawia false jako ze nie sa to lioczby pierwsze, i na koniec dzialania programu zostaje nam tablica wypelniona TRUE na indeksach ktorych licba indeksowa jest liczba pierwsza
    autor:               05212803054
    **************************************************** */
    void WyszukajLiczbyPierwsze(bool tablicaWartosci[]) {
        int pierwiastekDlugosciTablicy = sqrt(wielkoscTablicy);
        int wartoscZmiennaDoIndeksowania;
        for (int i = 2; i <= pierwiastekDlugosciTablicy; i++) {
            wartoscZmiennaDoIndeksowania = 2;
            for (int j = wartoscZmiennaDoIndeksowania * i; j < wielkoscTablicy; j = wartoscZmiennaDoIndeksowania * i) {
                wartoscZmiennaDoIndeksowania++;
                tablicaWartosci[j] = false;
            }
        }
    }

    void WypiszLiczbyPierwsze() {
        cout << "Liczby pierwsze z przedzialo od 2 do "<< wielkoscTablicy-1 << endl;
        for (int i = 2; i < wielkoscTablicy; i++) {
            if (tablicaLiczbDoPrzeszukania[i]) {
                cout << i << " ";
            }
        }
        cout << endl;
    }

    void GlownaFunkcjaSitaErastotelesa() {
        WypelnijTabliceDanymi(tablicaLiczbDoPrzeszukania);
        WyszukajLiczbyPierwsze(tablicaLiczbDoPrzeszukania);
        WypiszLiczbyPierwsze();
    }
};

int main(){
    setlocale(LC_CTYPE, "polish");

    SitoErastotelesa sito;
    sito.GlownaFunkcjaSitaErastotelesa();

    return 0;
}
