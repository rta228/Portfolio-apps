#include <iostream>
#include <cmath>
#include <stdexcept>
//Zaprojektowac klase, ktora pozwoli wyznaczy pole figur, ktore maja liczbe bokow wieksza niz 3.
//Klasa powinna wyznaczac takze obwod figury
//Jezeli rozwiazanie nie bedzie mozliwe uzasadnic dlaczego

class Figura {
private:
    int liczbaBokow;

public:
    Figura(int liczbaBokow) {
        if (liczbaBokow <= 3) {
            std::cout<<"Liczba boków musi byæ wiêksza ni¿ 3.";
        }
        this->liczbaBokow = liczbaBokow;
    }

    virtual double obliczPole() const {
        std::cout<<"Obliczanie pola dla tej figury nie jest zaimplementowane.";
    }

    virtual double obliczObwod() const {
        std::cout<<"Obliczanie obwodu dla tej figury nie jest zaimplementowane.";
    }
};

class Kwadrat : public Figura {
private:
    double a;

public:
    void setValues(double pA){
        pA=a;
    }

    void getValues(){
        a=0;
        if(a==0){
            std::cout<<"Podaj bok A: "; std::cin>>a;
            if (a <= 0) {
                std::cout<<"D³ugoœæ boku kwadratu musi byæ wiêksza od zera.";
                getValues();
            }else{
                outPut();
            }
        }
    }

    double field() const override {
        return a * a;
    }

    double obwod() const override {
        return 4 * a;
    }
    void outPut(){
        std::cout<<"\nPole: "<<field(a)<<"\nObwod: "<<obwod(a);
    }
};

class Romb : public Figura {
private:
    double a, h;

public:
    void setValues(double pA, double pH){
        pA=a;
        pH=h;
    }

    void getValues(){
        a=0;h=0;
        if(h==0){
            std::cout<<"Podaj bok A: "; std::cin>>a;
            std::cout<<"Podaj wysokosc H: "; std::cin>>h;
            if (a <= 0 || h <= 0) {
                std::cout<<"D³ugoœæ boków rombu i jego wysokoœæ musz¹ byæ wiêksze od zera.";
                getValues();
            }else{
                outPut();
            }
        }
    }

    double field() const override {
        return a * h;
    }

    double obwod() const override {
        return 4*a;
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,h)<<"\nObwod: "<<obwod(a);
    }
};

class Prostokat : public Figura {
private:
    double a, b;

public:
    void setValues(double pA, double pB){
        pA=a;
        pB=b;
    }

    void getValues(){
        a=0;b=0;
        if(b==0){
            std::cout<<"Podaj bok A: "; std::cin>>a;
            std::cout<<"Podaj bok B: "; std::cin>>b;
            if (a <= 0 || b <= 0) {
                std::cout<<"D³ugoœci boków prostok¹ta musz¹ byæ wiêksze od zera."<<std::endl;
                getValues();
            }else{
                outPut();
            }
        }
    }

    double field() const override {
        return a * b;
    }

    double obwod() const override {
        return 2 * (a + b);
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,b)<<"\nObwod: "<<obwod(a,b);
    }
};

class Rownoleglobok : public Figura {
private:
    double a, b, h;

public:
    void setValues(double pA, double pB, double pH){
        pA=a;
        pB=b;
        pH=h;
    }

    void getValues(){
        a=0;b=0;h=0;
        if(h==0){
            std::cout<<"Podaj bok A: "; std::cin>>a;
            std::cout<<"Podaj bok B: "; std::cin>>b;
            std::cout<<"Podaj bok H: "; std::cin>>h;
            if (a <= 0 || b <= 0 || h <= 0) {
                std::cout<<"D³ugoœci boków równoleg³oboku i jego wysokoœæ musz¹ byæ wiêksze od zera."<<std::endl;
                getValues();
            }else{
                outPut();
            }
        }
    }

    double field() const override {
        return a * h;
    }

    double obwod() const override {
        return 2 * (a + b);
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,h)<<"\nObwod: "<<obwod(a,b);
    }
};

class Trapez : public Figura {
private:
    double a, b, c, d, h;

public:
    void setValues(double pA, double pB, double pC, double pD, double pH){
        pA=a;
        pB=b;
        pC=c;
        pD=d;
        pH=h;
    }

    void getValues(){
        a=0;b=0;c=0;d=0;h=0;
        if(h==0){
            std::cout<<"Podaj bok A: "; std::cin>>a;
            std::cout<<"Podaj bok B: "; std::cin>>b;
            std::cout<<"Podaj bok C: "; std::cin>>c;
            std::cout<<"Podaj bok D: "; std::cin>>d;
            std::cout<<"Podaj bok H: "; std::cin>>h;
            if(a <= 0 || b <= 0 || c <= 0 || d <= 0 || h <= 0){
                std::cout<<"D³ugoœci boków trapezu i jego wysokoœæ musz¹ byæ wiêksze od zera."<<std::endl;
                getValues();
            }else{
                outPut();
            }
        }
    }

    double field() const override {
        return 0.5 * (a + b) * h;
    }

    double obwod() const override {
        return a + b + c + d;
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,b,h)<<"\nObwod: "<<obwod(a,b,c,d);
    }
};

int main()
{
    cout << "Hello world!" << endl;
    return 0;
}
