#include <iostream>
#include <string>
#include "Element.h"
using namespace std;
class Cewka : public Element {
private:
    double Indukcja;

public:
    Cewka(string nazwa, double indukcja) : Element(nazwa), Indukcja(indukcja) {}

    void Wymuszenie(double prad = 0, double napiecie = 0) override {
        cout << "Dla Cewki " << Nazwa << ": ";
        Element::Wymuszenie(prad, napiecie);
    }
};

