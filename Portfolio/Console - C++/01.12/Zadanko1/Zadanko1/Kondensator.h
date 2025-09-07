#include <iostream>
#include <string>
#include "Element.h"
using namespace std;
class Kondensator : public Element {
private:
    double Pojemnosc;

public:
    Kondensator(string nazwa, double pojemnosc) : Element(nazwa), Pojemnosc(pojemnosc) {}

    void Wymuszenie(double prad = 0, double napiecie = 0) override {
        cout << "Dla Kondensatora " << Nazwa << ": ";
        Element::Wymuszenie(prad, napiecie);
    }
};