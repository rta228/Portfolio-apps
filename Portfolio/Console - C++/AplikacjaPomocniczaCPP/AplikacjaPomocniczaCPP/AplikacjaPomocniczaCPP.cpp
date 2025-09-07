#include <iostream>
using namespace std;

class SzukanieZWartownikiem { //Zad 1 - egzamin 2022 06
public:
    int liczbaSzukana = 0;
    int wielkoscTablocy = 75; // Definicja wielkosci tablicy
    int tablicaWartosci[75 + 1]; // Definicja tabliocy

    SzukanieZWartownikiem(); // Konstruktor domyslny - wywoluje jakies zdarzenia gdy tworzymy obiekt klasy

    SzukanieZWartownikiem(int pLiczbaSzukana) {
        liczbaSzukana = pLiczbaSzukana;
        // Konstruktor z parametrami, przypisuje wprowadzone w main() wartosci do klasy
    }

    ~SzukanieZWartownikiem() {
        // Destruktor wywoulje sie gdy usuwamy obiekt klasy
        cout << "Do zobaczenia" << endl;
    };

    void wypelnienieTablicy() {
        srand(time(NULL)); // Zerowanie czasu co wplywa na to ze liczby sa naporawde pseudoloswe
        for (int i = 0; i < wielkoscTablocy; i++) {
            tablicaWartosci[i] = (rand() % 100) + 1; // Losowanie i przypisanie liczb do pol tablicy, Wartosc po % okresla ile liczb od liczby startowej ( tej po + ) ma byc w puli losowania
        }
        tablicaWartosci[wielkoscTablocy] = liczbaSzukana; // Dodanie liczbySzukanej na koniec tabliocy (wartownik) ktora zapobiega wyjsciu poza tablice
    }

    void wypiszTablice() {
        cout << "\nWypisanie tablicy" << endl;
        for (int i = 0; i <= wielkoscTablocy; i++) {
            cout << tablicaWartosci[i] << ", ";
        }
        cout << endl;
    }

    int szukanieLiczby() {
        // Zadanie mozna wykonac na pare sposobow. Ja umiem dwa z nich.

        // Sposob 1
        /*
        for (int i = 0; i <= wielkoscTablocy+1; i++) {
            if (tablicaWartosci[i] == liczbaSzukana) {
                if (i != wielkoscTablocy) {
                    return i;
                }
                else {
                    return -1;
                }
            }
        }
        */

        // Sposob 2
        bool znalezionoLiczbeSzukana = false;
        int i = 0;
        while (!znalezionoLiczbeSzukana) {
            if (tablicaWartosci[i] == liczbaSzukana) {
                if (i != wielkoscTablocy) {
                    return i;
                }
                else {
                    return -1;
                }
            }
            i++;
        }
    }

    void funkcjaGlownaSzukaniaZWartownikiem() {
        wypelnienieTablicy();
        wypiszTablice();
        int oSzukanieLiczby = szukanieLiczby(); // Wartosc outputu funkcji
        if (oSzukanieLiczby != -1) {
            cout << "Liczba zostala znaleziona pod indeksem: " << oSzukanieLiczby << endl;
        }
        else {
            cout << "Liczba nie zostala znaleziona" << endl;
        }
    }
};
SzukanieZWartownikiem::SzukanieZWartownikiem() {
    // Wszystkie metody mozemy definiowac poza klasa w taki sposob, jednakze m
    cout << "Witaj w programie Szukanie z Wartownikiem" << endl;
}


class SortowaniePrzezWstawianie { //Zad 2 - egzamin 2021 06
private:
    int WyszukiwanieMaksimum(int i) {
        int max = i;
        for (int j = i; j < wielkoscTablicy;j++) {
            if (tablicaWartosci[j] > tablicaWartosci[max]) {
                max = j;
            }
        }
        return max;
    }

public:
    int wielkoscTablicy = 10;
    int tablicaWartosci[10];
    SortowaniePrzezWstawianie() {
        cout<<"Witamy w programie SortowaniePrzezWstawianie" << endl;
    }
    void WprowadzanieDanych() {
        cout << "Wprowadz element tablicy do posortowania" << endl;
        for (int i = 0; i < wielkoscTablicy;i++) {
            cout << "Element " << i + 1 << ": "; cin >> tablicaWartosci[i];
        }
        cout << "\nElementy zostaly wprowadzone" << endl;
    }

    void FunkcjaSortujaca() {
        int zmiennaChwilowa = 0;
        for (int i = 0; i < wielkoscTablicy - 1; i++) {
            int maksymalneId = WyszukiwanieMaksimum(i);
            if (maksymalneId != 1) {
                zmiennaChwilowa = tablicaWartosci[i];
                tablicaWartosci[i] = tablicaWartosci[maksymalneId];
                tablicaWartosci[maksymalneId] = zmiennaChwilowa;
            }
        }
        cout << "Tablica zostala posortowana" << endl;
    }

    void WyswietlenieTablicy() {
        cout << "Tablica" << endl;
        for (int i = 0;i < wielkoscTablicy;i++) {
            cout << tablicaWartosci[i] << " ";
        }cout << endl;
    }
};

class KodowanieGadebyporuki { // Zad 3 - Informator inf 04
    string tekstZaszyfrowany; //Pamietaj jak nie dasz przed zmienna albo metoda nic w klasie to bazowo ma PRIVATE
public:
    string tekstDoZaszyfrowania;
    KodowanieGadebyporuki() {
        cout << "Witamy w programie KodowanieGadebyporuki" << endl;
    }

    void setData(string tekstDoZaszyfrowania) {
        this->tekstDoZaszyfrowania = tekstDoZaszyfrowania; //Inna medota przypisywania danych z zewnatrz klasy
    }

    void WprowadzanieDanych() {
        cout << "Wprowadz tekst do zaszyfrowania (najlepiej 20 znakow): "; cin >> tekstDoZaszyfrowania;
        cout << "Tekst zostal wprowadzony" << endl;
    }

    // Ogolnie te zadanie jest dosc proste i mozna je wykonac bardzo lopatologivznie.
    void SzyfrujDane() {
        for (int i = 0;i < tekstDoZaszyfrowania.length();i++) {
            if (tolower(tekstDoZaszyfrowania[i])=='p') { //Pamietaj string to jest tablica znakow i mozesz cos takiego zrobic, toLower dodajemy aby zawsze char sprawdzany byl maly, inaczej potrzebujemy 2 warunkow =="p" && =="P" bo maja inne kody binarne
                tekstDoZaszyfrowania[i] = 'o';
            }
            else if (tolower(tekstDoZaszyfrowania[i]) == 'o') {
                tekstDoZaszyfrowania[i] = 'p';
            }
            else if (tolower(tekstDoZaszyfrowania[i]) == 'g') {
                tekstDoZaszyfrowania[i] = 'a';
            }
            else if (tolower(tekstDoZaszyfrowania[i]) == 'a') {
                tekstDoZaszyfrowania[i] = 'g';
            }
            else if (tolower(tekstDoZaszyfrowania[i]) == 'y') {
                tekstDoZaszyfrowania[i] = 'r';
            }
            else if (tolower(tekstDoZaszyfrowania[i]) == 'r') {
                tekstDoZaszyfrowania[i] = 'y';
            }
            else {
                //Nic sie nie zmienia
            }
        }
        cout << "Dane zpstallu posrotowane" << endl;
    }
    
    void WypiszDane() {
        cout << "Tekst: " << tekstDoZaszyfrowania << endl;
    }
};

class TeKurwaJebaneKostki { // Zad 4 - Egzamin 2024 06
    int* tablicaKostek; // Tablica dynamiczna czyli ze moze byc jej wielkosc zmieniana
    int iloscKostek = 0;
    int wynikKostek; // Jak widac w programie nie potrzebujemy aby wyn ik byl zapisywany bo jest dla kazdego losowania oddzielny
    // Ale ja zrobie tak i bede zerowal wyniki
public:
    TeKurwaJebaneKostki() {
        cout << "Witamy w programie TeKurwaJebaneKostki" << endl;
    }

    void WprowadzDane() {
        while (iloscKostek < 3 || iloscKostek>10) {
            cout << "Podaj ile kostek rzucamy (3-10): ";cin >> iloscKostek;
        }
        tablicaKostek = new int[iloscKostek];
    }

    void LosowanieKostek() {
        srand(time(NULL));
        for (int i = 0; i < iloscKostek; i++){
            tablicaKostek[i] = (rand() % 6) + 1;
            cout << "Kostka " << i << " : " << tablicaKostek[i]<<endl;
        }
    }

    void SUmowanieWynikow() {
        wynikKostek = 0; // Zerowanie wynikow
        for (int i = 0;i < iloscKostek;i++) {
            for (int j = 0;j < iloscKostek;j++) {
                if (tablicaKostek[i]==tablicaKostek[j]&&i!=j) { // Sprawdzamy czy sa takie same oczka + czy to nie ta sanma kostka
                    wynikKostek += tablicaKostek[i];
                    break; // Tutaj przerywamny petle J aby nie naliczaly nam sie wyniki kilka razy
                }
            }
        }
        cout << "Liczba uzyskanych punktow: " << wynikKostek<<endl;
    }

    void GlownaFunkcja() {
        WprowadzDane();
        char wybor = 0;
        while (wybor=='t' && wybor != 'n') { // Dopoki nie wybierzemy n bedziemy grac
            LosowanieKostek();
            SUmowanieWynikow();
            cout << "Jeszcze raz? (t/n)"<<endl;cin >> wybor;
        }
    }

};

class PESEL { // Zad 5 - Egzamin 2024 01
    int tablicaWartosciKontrolnej[10] = {1,3,7,9,1,3,7,9,1,3};
    string pesel = "05212803054";
public:
    PESEL() {
        cout << "Witaj w programie PESEL" << endl;
    }

    void UstawianieDanych(string pPesel) { //Przypisanie danych jesli program wymaga od nas zmiennych zeby byly private albo protected
        pesel = pPesel;
    }

    void WprowadzanieDanych() {
        cout << "Prosze podac swoj PESEL (11 znakow): "; cin >> pesel;
    }

    bool SprawdzaniePoprawnosciPeselu() {
        int cyfraKontrolnaPeselu = (pesel[10]-'0'); // Tutaj znow te kody ASCI ogolnie tak wyglada konwersja z char na INT
        int S = 0;
        int M = 0;
        int R = 0;
        for (int i = 0; i < 10; i++) { //Tutaj pprzechodzimy po kazdym indeksie PESELa i mnozymy jego wartosci a nastepnie sumujemy do zmiennej S
            S += (pesel[i] - '0') * tablicaWartosciKontrolnej[i]; // Tutaj wchodzimy w kody ASCII i ogolnie char na int musimy odjac liczbe CHAR ASCII czyli 48 ale tutaj mozemy odjac po prostu chara i wyjdzie nam dobry wynik
        }
        M = S % 10; // Usuwamyu dziesiatki i setki z liczby i zostaje nam cyfra jednosci, MODULO (%) daje nam reszte z tej danej cyfyr
        if (M == 0) {
            R = 0;
        }
        else {
            R = 10 - M;
        }
        //cout << "Cyfra kontrolna" << cyfraKontrolnaPeselu << ", Suma Kontrolna" << R<<endl;
        if (R == cyfraKontrolnaPeselu) {
            return true;
        }
        else {
            return false;
        }
    }

    char SprawdzaniePlci() {
        int pozycjaNumeruPlci = pesel.length()-2;
        if (pesel[pozycjaNumeruPlci]%2==0) { //Sprawdzanie plci w peselu
            return 'K';
        }
        else {
            return 'M';
        }
    }

    void FunkcjaGlowna() {
        WprowadzanieDanych();

        char plec = SprawdzaniePlci();
        bool kontrolna = SprawdzaniePoprawnosciPeselu();

        if (plec == 'K') {
            cout << "Jestes kobieta" << endl;
        }
        else if (plec == 'M') {
            cout << "Jestes mezczyzna" << endl;
        }

        if (kontrolna) {
            cout << "Pesel jest poprawny" << endl;
        }
        else {
            cout << "Pesel nie jest poprawny" << endl;
        }
    }
};

class WyszukiwanieBinarne { //Zad 6 - Wlasne
    int wielkoscTablicy = 20;
    int tablicaWartosciDoPrzeszukania[20] = {1,4,6,10,12,23,65,143,143,155,235,256,390,420,515,690,700,777,808,999}; // Musza byc posortowane rosnaco
    int liczbaSzukana;
public:
    WyszukiwanieBinarne() {
        cout << "Witamy w programie WyszukiwanieBinarne" << endl;
    }

    void WprowadzDane() {
        cout << "Wprowadz liczbe szukana dla tablicy: "; WyswietlDaneTablicy();
        cout << "Liczba szukana: "; cin >> liczbaSzukana;
        
    }

    void WyswietlDaneTablicy() {
        for (int i = 0; i < wielkoscTablicy; i++) {
            cout << tablicaWartosciDoPrzeszukania[i] << ", ";
        }
        cout << endl;
    }

    /******************************************************** 
    * nazwa funkcji:       WyszukajBinarnie 
    * parametry wejściowe: element - Liczba Calkowita, element ktory ma zostac wyszukany w tablicy wartosci 
    * wartość zwracana:    Dwie mozliwosci: Element zostal znaelziony wtedy zwracana jest liczba calkowita z indeksem pod ktorym znajduje sie ten element w tablicy lub Element nie zostal znaleziony wtedy zwraca sie -1
    * autor:               <05212803054 
    * ****************************************************/
    int WyszukajBinarnie(int element) {
        int lewyIndeks = 0;
        int prawyIndeks = wielkoscTablicy-1;
        int srodkowyIndeks = 0;
        while (prawyIndeks > lewyIndeks) {
            srodkowyIndeks = ceil((prawyIndeks + lewyIndeks) / 2);
            if (tablicaWartosciDoPrzeszukania[srodkowyIndeks] == element) {
                return srodkowyIndeks;
            }
            else {
                if (element < tablicaWartosciDoPrzeszukania[srodkowyIndeks]) {
                    prawyIndeks = srodkowyIndeks - 1;
                }
                else {
                    lewyIndeks = srodkowyIndeks + 1;
                }
            }
        }
        return -1;
    }

    void FunkcjaGlownaWyszukiwaniaBinarnego() {
        WprowadzDane();
        int wynikWyszukiwaniaBinarnego = WyszukajBinarnie(liczbaSzukana);
        if (wynikWyszukiwaniaBinarnego==-1) {
            cout << "Element szukany: "<< liczbaSzukana << " nie zostal znaleziony w tablicy" << endl;
        }
        else {
            cout << "Element szukany: " << liczbaSzukana << " zostal znaleziony w tablicy i znajduje sie pod indeksem: "<< wynikWyszukiwaniaBinarnego << endl;
        }
    }
};

class SzyfrowanieCezara {
    int przesuniecieSzyfru;
    string ciagDoZaszyfrowania;
    string ciagZaszyfrowany;
    string tablicaZnakowDoSzyfrowania = "abcdefghijklmnoprstuwyzABCDEFGHIJKLMNOPRSTUWYZ";

public:
    SzyfrowanieCezara() {
        cout << "Witamy w programie SzyfrowanieCezara" << endl;
    }

    void WprowadzDane() {
        cout << "Wprowadz tekst do zaszyfrowania: "; cin >> ciagDoZaszyfrowania; 
        cout << "\nWprowadz przesuniecie szyfru: "; cin >> przesuniecieSzyfru;
    }

    string ZaSzyfruj(string tekst, int przesuniecie) {
        int iloscZnakowDoPrzeszukaniaWTablicyZnakow = tablicaZnakowDoSzyfrowania.length();
        int iloscZnakowDoPrzeszukaniaWCiagu = ciagDoZaszyfrowania.length();
        int prawdziwePrzesuniecie = 0;
        for (int i = 0; i < iloscZnakowDoPrzeszukaniaWCiagu; i++) {
            for (int j = 0; j < iloscZnakowDoPrzeszukaniaWTablicyZnakow; j++) {
                if (ciagDoZaszyfrowania[i] == tablicaZnakowDoSzyfrowania[j]) {
                    if (j + przesuniecieSzyfru > iloscZnakowDoPrzeszukaniaWTablicyZnakow) {
                        prawdziwePrzesuniecie = (j + przesuniecieSzyfru) % iloscZnakowDoPrzeszukaniaWTablicyZnakow;
                        ciagZaszyfrowany[i] = tablicaZnakowDoSzyfrowania[prawdziwePrzesuniecie];
                    }
                    else {
                        prawdziwePrzesuniecie = j + przesuniecieSzyfru;
                        ciagZaszyfrowany[i] = tablicaZnakowDoSzyfrowania[prawdziwePrzesuniecie];
                    }
                }
            }
            ciagZaszyfrowany[i] = ciagDoZaszyfrowania[i];
        }
        return ciagZaszyfrowany;
    }

    string OdSzyfruj(string tekst, int przesuniecie) {
        return "NOTHING";
    }

    void WypiszDane() {
        cout << "Ciag zaszyfrowany: " << ZaSzyfruj(ciagDoZaszyfrowania, przesuniecieSzyfru)<<endl;
    }

    void FunkcjaGlownaSzyfrowaniaCezara() {
        WprowadzDane();
        WypiszDane();
    }
};

int main() {
    setlocale(LC_CTYPE, "polish");
    /*
    //Zad 1
    int zad1SzukanaLiczba;
    cout << "Zadanie 1: Prosze podac szukana liczbe (Zakres liczb od 1 do 100): "; cin >> zad1SzukanaLiczba;
    SzukanieZWartownikiem obiektSzukaniaZWartownikiem1(zad1SzukanaLiczba); // Tworzenie obiektu z parametren starotwym
    obiektSzukaniaZWartownikiem1.funkcjaGlownaSzukaniaZWartownikiem(); // Wywoalnie funkcji obiektu
    //delete &obiektSzukaniaZWartownikiem1; // Usuwanie obiektu

    //Zad 2
    SortowaniePrzezWstawianie sortowanie; // Tworazenie obiektu
    sortowanie.WprowadzanieDanych();
    sortowanie.WyswietlenieTablicy();
    sortowanie.FunkcjaSortujaca();
    sortowanie.WyswietlenieTablicy();

    //Zad 3
    KodowanieGadebyporuki kodowanie;
    kodowanie.WprowadzanieDanych();
    kodowanie.SzyfrujDane();
    kodowanie.WypiszDane();
    
    //Zad 4
    TeKurwaJebaneKostki kostkiProgram;
    kostkiProgram.GlownaFunkcja();

    //Zad 5
    PESEL Pesel1;
    Pesel1.FunkcjaGlowna();

    //Zad 6
    WyszukiwanieBinarne wyszukiwanieBinarne1;
    wyszukiwanieBinarne1.FunkcjaGlownaWyszukiwaniaBinarnego();
    */
    SzyfrowanieCezara szyfrowanieCezara;
    szyfrowanieCezara.FunkcjaGlownaSzyfrowaniaCezara();

    return 8080;
}