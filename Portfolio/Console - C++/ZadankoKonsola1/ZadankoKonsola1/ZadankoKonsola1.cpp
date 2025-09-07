// ZadankoKonsola1.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.

/*
Klasa dentysta dziedziczaca po Lekarz
Pola: imie, nazwisko, specjalizacja
*/


#include <iostream>
#include <vector>
using namespace std;



class Dentysta{
protected:
    string imie, nazwisko, specjalizacja;

public:
    static float pensja;
    float ekxpensja;
    Dentysta() {
    }

    Dentysta(string pImie, string pNazwisko) {
        imie = pImie;
        nazwisko = pNazwisko;
        specjalizacja = "Dentysta";
        ekxpensja = pensja;
    }

    Dentysta(string pImie, string pNazwisko, float pEkspensja){
        imie = pImie;
        nazwisko = pNazwisko;
        specjalizacja = "Dentysta";
        ekxpensja = pEkspensja;
    }



    void Show() {
        cout << specjalizacja<<endl;
        cout << "Imie: " << imie<<", Nazwisko: "<<nazwisko;
        cout << "\nZarobki: " << ekxpensja<<endl;
    }
};

float Dentysta::pensja = 5000;

class Clinic {
protected:
    vector <Dentysta> vec;
public:
    void dodajDetyste(Dentysta d) {
        vec.push_back(d);
    }

    void show() {
        cout << "\nKLINIKA Auuuuuuu"<<endl;
        for (int i = 0; i < vec.size(); i++) {
            vec[i].Show();
        }
    }
};

int main()
{
    Dentysta* dent1 = new Dentysta("Domino", "Wojtysiak", 10000);
    Dentysta* dent2 = new Dentysta("Jan", "Nowak");

    Clinic przychodnia;
    przychodnia.dodajDetyste(* dent1);
    przychodnia.dodajDetyste(* dent2);
    przychodnia.show();

    dent1->ekxpensja = 6900.99;
    przychodnia.dodajDetyste(*dent1);
    przychodnia.show();

    return -1;
}
