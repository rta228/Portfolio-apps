// AplikacjaKlasowe.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
#include <iostream>
using namespace std;

class Prostokat {
protected:
    int a, b;

public:

    Prostokat() {
        cout << "\nKonstruktor Prostokat" << endl;
    }

    Prostokat(int pA, int pB) {
        pA = a;
        pB = b;
    }

    void show() {
        cout << "Bok A: " << a << "\nBok B: " << b << endl;
    }
};

class Kwadrar:Prostokat{
    int aK;

public:
    Kwadrar() {
        cout << "\nKonstruktor Kwadrar" << endl;
    }

    Kwadrar(int aK) {
        this->aK;
    }
};

class Pieciakot : public Prostokat {
    int c;

public:
    Pieciakot() {
        cout << "\nKonstruktor Pieciakot" << endl;
    }
    Pieciakot(int pA, int pB, int pC) :Prostokat(a,b){
        pA = a;
        pB = b;
        pC = c;
    }

    void show() {
        cout << "Bok A: " << a << "\nBok B: " << b << "\nBok C: " << b << endl;
    }
};

class PieciakotB : public Prostokat {
    int c;

public:
    PieciakotB() {
        cout << "\nKonstruktor PieciakotB" << endl;
    }
    PieciakotB(int pA, int pB, int pC) :Prostokat(a, b) {
        pA = a;
        pB = b;
        pC = c;
    }

    void show() {
        cout << "Linia boczna A: " << a << "\nLinia boczna  B: " << b << "\nLinia boczna  C: " << b << endl;
    }
};

int main()
{
    Prostokat p;
    p.show();

    Prostokat* p2= new Prostokat;
    p2->show();

    Pieciakot p1;
    p1.show();

    PieciakotB pB1;
    pB1.show();

    Prostokat* pro1 = new Pieciakot;
    Prostokat* pro2B = new PieciakotB;

    pro1->show();
    pro2B->show();

    return -1;
}