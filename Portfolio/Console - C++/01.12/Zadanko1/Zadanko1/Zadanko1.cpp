#include <iostream>
#include <string>
#include "Element.h"
#include "Kondensator.h"
#include "Cewka.h"
#include "Rezystor.h"
using namespace std;




int main() {
    Rezystor r("R1", 50.0);
    Cewka c("L1", 10.0);
    Kondensator k("C1", 20.0);

    r.Wymuszenie(2.5, 10.0);
    c.Wymuszenie(1.0, 5.0);
    k.Wymuszenie(0.5, 2.0);

    return 0;
}
