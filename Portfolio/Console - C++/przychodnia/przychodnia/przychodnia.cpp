#include <iostream>
#include <vector>
using namespace std;

/*
Lekarz:
imie, nazwikso, specjalizacja
*/

class Lekarz {
protected:
    string imie, nazwisko;
    string specjalizacja;
    float pensja;
    float static pensjaPodstawowa;
    int rokZatrudnienia;
    int rokOstatniejZmianyPensji;

public:
    Lekarz() {
        imie = "Andrzej";
        nazwisko = "Sieradzki";
        specjalizacja = "Lekarz";
        pensja = 8000.02;
        rokZatrudnienia = 2024;
        rokOstatniejZmianyPensji = 0;
    };

    Lekarz(string pImie, string pNazwisko, int pRokZatrudnienia) {
        imie = pImie;
        nazwisko = pNazwisko;
        pensja = pensjaPodstawowa;
        rokZatrudnienia = pRokZatrudnienia;
        rokOstatniejZmianyPensji = 0;
    }

    Lekarz(string pImie, string pNazwisko, float pPensja, int pRokZatrudnienia) {
        imie = pImie;
        nazwisko = pNazwisko;
        pensja = pPensja;
        rokZatrudnienia = pRokZatrudnienia;
        rokOstatniejZmianyPensji = 0;
    }

    virtual void showData() const {
        cout << "\n" << specjalizacja << endl;
        cout << "Imie: " << imie << ", nazwisko: " << nazwisko<<endl;
        cout << "Pensja: " << pensja << ", rok ostatniej zmiany pensji: " << rokOstatniejZmianyPensji << endl;
        cout << "Rok zatrudnienia: " << rokZatrudnienia<<endl;
    }

    void giveRaise(float pPensja) {
        pensja += pPensja;
        //nazwisko = nazwisko + "0";
        rokOstatniejZmianyPensji = 2024;
    }

    void setSpecjalizacja(string pSpecjalizacja) {
        specjalizacja = pSpecjalizacja;
    }

};
float Lekarz::pensjaPodstawowa = 10000.33;


class Dentysta : public Lekarz {
private:
    bool robiInplanty = false;

public:
    Dentysta() : Lekarz(){
        setSpecjalizacja("Dentysta");
    }
    Dentysta(string pImie, string pNazwisko, bool pRobiInplanty, int pRokZatrudnienia) : Lekarz() {
        setSpecjalizacja("Dentysta");
    }
    Dentysta(string pImie, string pNazwisko, bool pRobiInplanty, float pPensja, int pRokZatrudnienia) : Lekarz() {
        setSpecjalizacja("Dentysta");
    }

    void showData() const override {
        Lekarz::showData();
        cout << "Dentysta robi implanty: " << robiInplanty << endl;
    }
};

class Ortopeda : public Lekarz {

public:
    Ortopeda() : Lekarz() {
        setSpecjalizacja("Ortopeda");
    };
    Ortopeda(string pImie, string pNazwisko, int pRokZatrudnienia) : Lekarz() {
        setSpecjalizacja("Ortopeda");
    }
    Ortopeda(string pImie, string pNazwisko, float pPensja, int pRokZatrudnienia) : Lekarz() {
        setSpecjalizacja("Ortopeda");
    }

    void showData() const {
        Lekarz::showData();
    }
};

class Przychodnia {
    vector<Lekarz*> vPrzychodnia;

};

int main(){
    setlocale(LC_CTYPE, "polish");
    cout << "Witaj" << endl;

    Lekarz Lekarz1;
    Lekarz1.showData();

    Dentysta* Dentysta1 = new Dentysta("Renata", "Sachniewicz", true, 20000.69, 2022);
    Dentysta1->showData();

    Ortopeda Ortoped1("Dominik", "Wojtysiak", 2020);
    Ortoped1.showData();

    Ortoped1.giveRaise(1500);
    Ortoped1.showData();

    Lekarz1.giveRaise(2500);
    Lekarz1.showData();

    return -1;
}
