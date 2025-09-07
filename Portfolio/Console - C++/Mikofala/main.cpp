#include <iostream>
#include <windows.h>

// Zapis funkcjonalny kuchenki - zaprojektowac program symulujacy dzialanie kuchenki mikrofalowej z uzyciem funkcji.
// interface uzytkownika pozwoli na okreslenie czasu podgrzewania (sleep), podajace opoznienie np w sekundach. Uzytkownik dostaje info ze potrawa jest gotowa.
// Oraz funkcji wyjscia ktora pozwoli zakonczyc prace kuchenki
using namespace std;


class Microwave {
private:
    int time;

public:
    void setData(int pTime){
        pTime = time;
    };

    void menuUzytkownika(){
        int odp;
        cout<<"________________________"<<endl;
        cout<<"Kuchenka mikrofalowa"<<endl;
        cout<<"START - 1"<<endl;
        cout<<"EXIT - 2"<<endl;
        cout<<"Twoja akcja: ";cin>>odp;
        switch(odp){
        case 1:
            getValues();
            break;
        case 2:
            turnOff();
            exit(0);
        default:
            cout<<"Podaj akcje z zakresu 1 - 2"<<endl;
            menuUzytkownika();
        }
    }

    void getValues(){
        time=0;
        if(time==0){
            cout<<"Czas podgrzewania w sekundach: ";
            cin>>time;
        }
        if(time<=0){
            cout<<"Czas podgrzewania nie moze byc mniejszy ani rowny 0 sekund"<<endl;
            getValues();
        }
        if(((time >= 'a') && (time<='z')) || ((time>='A') && (time<='Z'))){
            cout<<"Czas podgrzewania musi byc zapisany jako liczba"<<endl;
            getValues();
        }
        timer();
    }

    void timer(){
        int reszta = time%5;
        if(reszta!=0){
            cout<<"Potrawa bedzie gotowa za "<<time<<" sekund"<<endl;
            Sleep(reszta*1000);
            time = time-reszta;
            reszta=0;
            timer();
        }
        if(time!=0){
            cout<<"Potrawa bedzie gotowa za "<<time<<" sekund"<<endl;
            Sleep(5*1000);
            time-=5;
            timer();
        }else{
            cout<<"Potrawa jest gotowa"<<endl;
            timeChecker();
        }
    }

    void czasomierz(){
        while(true){
            timer();
        }
    }

    void timeChecker(){
        int value;
        cout<<"Czy chcesz jeszcze cos podgrzac?"<<endl<<"Tak = 1, Nie = 0: ";cin>>value;
        switch(value){
            case 1:
                getValues();
                break;
            case 0:
                turnOff();
                exit(0);
            default:
                turnOff();
                break;
        }
    }

    int turnOff(){
            return 0;
    }

};

int main(){
    Microwave mikrofala;
    mikrofala.menuUzytkownika();
}
