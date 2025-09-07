// Zaimplementuj metody oraz klasy ktore po nich dziedzicza w sposob dziedziczny: Rezystor, Cewka, Kondensator.
// Wszystkie klasy powinnyposiadac pub;liczny parametr: Nazwa, Oraz wlasciwosci nie publiczne: Prad i Napiecie
// Ponad to zaleznie od danego elementu powinny posiadac wlasne elementy charakterystyczzne: 
// Rezystancja, Indukcja, Pojemnosc (Rowniez niepubliczne). 
// Dla wszystkich klas zaimplementuj nastepujace metody: Konstruktor inicjalizujacy pole Nazwa ,
// oraz wlasciwosc charakterystyczna do tego elementu
// Oraz metode wymuszenie ktora jako argumenty Prad i Napiecie
// Wartosci poczatkowe dla pradu i napiecua wynosza 0 - czyli mozna te funkcje wykonac nie podajac argumentu.
// Zademonstruj jak dziala program
#ifndef ELEMENT
#define ELEMENT
#include <iostream>
#include <string>
using namespace std;
class Element {
public:
    string Nazwa;
    double Prad;
    double Napiecie;

    Element(string nazwa) : Nazwa(nazwa), Prad(0), Napiecie(0) {}

    virtual void Wymuszenie(double prad = 0, double napiecie = 0) {
        Prad = prad;
        Napiecie = napiecie;
        cout << "Wymuszenie dla " << Nazwa << ": \nPrad = " << Prad << ", \nNapiecie = " << Napiecie << endl;
    }

    Element() = default;
};

#endif