// Zadanko1.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
// Zaprojektowac dwie klasy klasa samochod amfibia
//  Klasa samochod ma posiadac pola string: marka, kolor; int: liczbaBiegow, mocSilnika
// Klasa samochod ma posiadac dwa konstruktory: Konstruktor domyslny(przypisywanie wartosci z klawiatury) oraz 
// Konstruktor z parametrami(przypisywanie wartosci domyslnych) oraz metode wypisz wypisujaca wszystkie wartosci
// Klasa amfibia dziedziczy po klasie auto marke i kolor.
// Zademonstrowac dzialanie klas programu

#include <iostream>
#include "Auto.h"
#include "Amfibia.h"
using namespace std;

int main() {
    Auto Auto1;

    cout << "\nInformacje o Autozie 1:\n";
    Auto1.wypisz();
    Auto1.jedz();

    Amfibia amfibia1("AmfibiaMarka", "Niebieski");

    cout << "\nInformacje o amfibii 1:\n";
    amfibia1.wypisz();

    amfibia1.plywaj();

    return 0;
}