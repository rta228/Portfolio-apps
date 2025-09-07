#pragma once
#include <iostream>
#include <string>
using namespace std;
class Auto {
private:
    string marka;
    string kolor;
    int liczbaBiegow;
    int mocSilnika;

public:
    Auto() {
        cout << "Podaj marke: ";
        cin >> marka;
        cout << "Podaj kolor: ";
        cin >> kolor;
        cout << "Podaj liczbe biegow: ";
        cin >> liczbaBiegow;
        cout << "Podaj moc silnika: ";
        cin >> mocSilnika;
    }

    Auto(string m, string k, int b, int moc) : marka("Audi"), kolor("Czerwone"), liczbaBiegow(5), mocSilnika(150) {};

    void wypisz() {
        cout << "Marka: " << marka << endl;
        cout << "Kolor: " << kolor << endl;
        cout << "Liczba biegow: " << liczbaBiegow << " KM" << endl;
        cout << "Moc silnika: " << mocSilnika << endl;
    }

    void jedz() {
        cout << "Auto jezdzi!" << endl;
    }
};


