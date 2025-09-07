//Zaprojektowac aplikacje ktora pozwoli na przechowywanie danych w postacii X oraz X^2
//Na podstawie klasy uzytkownik okresla rozmiar tablicy w sposob dynamiczny a obiekty sa uzupelniane automatycznie
//Przedstawic test programu demonstrujacy dzialanie aplikacji

#include <iostream>
using namespace std;
class Dane {
private: 
    int xBasic, xKwadrat;
    string text, wartoscZTekstu;
public:
    Dane(int xBasic = 0, int xKwadrat = 0, string wartoscZTekstu = "", string text = "") {
        this->xBasic = xBasic;
        this->xKwadrat = xKwadrat;
        this->wartoscZTekstu = wartoscZTekstu;
        this->text = text;
    }

    void GetInfoX() {
        cout << "\nPodaj X: "; cin >> xBasic;
        xKwadrat = xBasic * xBasic;
    }

    void showInfoX(int i) {
        cout << "\nObjekt: " << i << " , wartosc X: " << xBasic << " , wartosc X^2: " << xKwadrat;
    }

    void GetInfoT() {
        cout << "\nPodaj tekst: "; cin >> text;
    }

    void showInfoT() {
        for (int i = 0; i < size(text); i++) {
            wartoscZTekstu+=returnTheNumber(text[i]);
        }
        cout <<  " \nTekst: "<< text<< "\nWartosc wyrwana z tekstu: "<<wartoscZTekstu;
    }

    int returnTheNumber(char czarakter) {
        if (isdigit(czarakter)) {
            return czarakter;
        }
    }
};


int getTabSize() {
    int size;
    cout << "\nPodaj wielkosc tablicy: "; cin >> size;
    return size;
}

int main(){
    Dane dane;
    dane.GetInfoT();
    dane.showInfoT();
    /*
    int size = getTabSize();
    Dane* ktab = new Dane[size];
    for (int i = 0; i < size;i++) {
        ktab[i].GetInfoX();
    }
    for (int i = 0; i < size; i++) {
        ktab[i].showInfoX(i);
    }
    */
    return 0;
}