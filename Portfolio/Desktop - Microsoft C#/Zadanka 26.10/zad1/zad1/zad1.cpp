#include <iostream>
#include "MojaKlasa.h"
using namespace std;

MojaKlasa::MojaKlasa(int x, int y) {
    this->x = x;
    this->y = y;
}

void MojaKlasa::pisz() {
    cout << "\nX: "<<x<<"\nY: "<<y;
}

MojaKlasa MojaKlasa::fun() {
	MojaKlasa* tmp = new MojaKlasa(x, y);
	return(*tmp);
}