#include <iostream>
#include <string>
#include "Element.h"
using namespace std;

class Rezystor : public Element {
private:
    double Rezystancja;

public:
    Rezystor(string nazwa, double rezystancja) : Element(nazwa), Rezystancja(rezystancja) {}

    void Wymuszenie(double prad = 0, double napiecie = 0) override {
        cout << "Dla Rezystora " << Nazwa << ": ";
        Element::Wymuszenie(prad, napiecie);
    }
};
