#include <iostream>
using namespace std;

class Ulamek {
private:
    int licznik, mianownik, lCalkowita;

public:
    void setData(int pLicznik, int pMianownik, int pLCalkowita){
        pLicznik=licznik;
        pMianownik=mianownik;
        pLCalkowita=lCalkowita;
    }

    void checkData(int wartosc, int poz){
        if(!isdigit(wartosc)){
            cout<<"Wpisana wartosc musi byc liczba"<<endl;
            getData();
        }else{
            if(poz==2 && wartosc==2){
                cout<<"Mianownik nie moze byc rowny 0"<<endl;
                getData();
            }
        }
    }

    void getData(){
        cout<<"Podaj licznik ulamka: "; cin>>licznik; checkData(licznik, 1);
        cout<<"Podaj mianownik ulamka: "; cin>>mianownik; checkData(mianownik, 2);
    }

    virtual void pickOption(){}

    virtual int NWW(){};
    virtual int NWD(){};

};

int NWD(int a, int b){
    while (a != b) {
        if(a > b)
            a = a - b;
        else
            b = b - a;
    }

    return a;
}

int NWW(int a, int b) {
    return a*b/NWD(a, b);
}

void pickOption(licznik1, mianownik1, licznik2, mianownik2){
    int wybor;
    cout<<"Co chcesz teraz zrobic?\nDodawanie - 1\nOdejnomwanie - 2\nMnozenie - 3\nDzielenie - 4\nTwoj wybor: "; cin>>wybor; checkData(wybor, 1);
    switch(wybor){
    case 1:
        cout<<"Wynik dodawania: "<<dodawanie(licznik1, mianownik1, licznik2, mianownik2);
        break;
    case 2:
        cout<<"Wynik odejmowania: "<<odejmowanie(licznik1, mianownik1, licznik2, mianownik2);
        break;
    case 3:
        cout<<"Wynik mnozenia: "<<mnozenie(licznik1, mianownik1, licznik2, mianownik2);
        break;
    case 4:
        cout<<"Wynik dzielenia: "<<dzielenie(licznik1, mianownik1, licznik2, mianownik2);
        break;

    default:
        cout<<"Nieznana operacja - powtorz wybor!";pickOption();
    }
}

void dodawanie(int licznik1, int mianownik1, int licznik2, int mianownik2){

}

void odejmowanie(int licznik1, int mianownik1, int licznik2, int mianownik2){

}

void mnozenie(int licznik1, int mianownik1, int licznik2, int mianownik2){

}

void dzielenie(int licznik1, int mianownik1, int licznik2, int mianownik2){

}

int main(){

    return 0;
}
