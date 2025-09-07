#include <iostream>
#include "MojaKlasa.h"
using namespace std;

int main()
{
	MojaKlasa mojaklasa1(2, 3);
	mojaklasa1.pisz();
	MojaKlasa mojaklasa2(3,4);
	cout << "\nPo utworzeniu obiektu";
	mojaklasa2.pisz();
	mojaklasa2=mojaklasa1.fun();
	cout << "\nPo skopowaniu obiektu";
	mojaklasa2.pisz();
	return 0;
}