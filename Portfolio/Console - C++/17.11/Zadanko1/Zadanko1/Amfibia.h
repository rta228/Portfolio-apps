#pragma once
#include "Auto.h"
using namespace std;
class Amfibia : public Auto {
public:
    Amfibia(string m, string k) : Auto(m, k, 5, 150) {}

    void plywaj() {
        cout << "Amfibia plywa!" << endl;
    }
};

