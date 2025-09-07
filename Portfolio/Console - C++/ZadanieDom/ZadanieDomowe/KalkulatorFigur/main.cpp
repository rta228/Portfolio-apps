#include <iostream>
#include <cmath>
#include <stdexcept>
//Zaprojektowac klase, ktora pozwoli wyznaczy pole figur, ktore maja liczbe bokow wieksza niz 3.
//Klasa powinna wyznaczac takze obwod figury
//Jezeli rozwiazanie nie bedzie mozliwe uzasadnic dlaczego

class Figura {
private:
    int liczbaBokow;
    double a;

public:
	void setValues(int pLiczbaBokow,double pA){
        pLiczbaBokow=liczbaBokow;
		pA=a;
    }

    void getValues(){
        a=0;
        if(a==0){
        	std::cout<<"Wilokat";
        	std::cout<<"\nPodaj liczbe Bokow: "; std::cin>>liczbaBokow;
            std::cout<<"\nPodaj bok A: "; std::cin>>a;
            if (a <= 0) {
                std::cout<<"Dlugosc boku wielokata musi byc wieksza od zera.";
                getValues();
            }
			if (liczbaBokow <= 3) {
            	std::cout<<"Liczba boków musi byc wieksza niz 3.";
            	getValues();
        	}
			else{
                outPut();
            }
        }
    }

    virtual double field(int liczbaBokow,double a) const { // virualna - wywoływana w wersji odpowiadającej rzeczywistemu typowi
    	double s = a/(2*tan(M_PI/liczbaBokow)); // const - const za metodą informuje, że nie ulega zmianie stan obiektu
        return 0.5 * liczbaBokow * s * a;
    }

    virtual double obwod(int liczbaBokow, double a) const {
        return a*liczbaBokow;
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(liczbaBokow,a)<<"\nObwod: "<<obwod(liczbaBokow,a)<<std::endl;
    }
};

class Kwadrat{
private:
    double a;

public:
    void setValues(double pA){
        pA=a;
    }

    void getValues(){
        a=0;
        if(a==0){
        	std::cout<<"KWADRAT";
            std::cout<<"\nPodaj bok A: "; std::cin>>a;
            if (a <= 0) {
                std::cout<<"Dlugosc boku kwadratu musi byc wieksza od zera.";
                getValues();
            }else{
                outPut();
            }
        }
    }

    virtual double field(double a) const {
        return a * a;
    }

    virtual double obwod(double a) const {
        return 4 * a;
    }
    void outPut(){
        std::cout<<"\nPole: "<<field(a)<<"\nObwod: "<<obwod(a)<<std::endl;
    }
};

class Romb{
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
        	std::cout<<"\nROMB";
            std::cout<<"\nPodaj bok A: "; std::cin>>a;
            std::cout<<"Podaj wysokosc H: "; std::cin>>h;
            if (a <= 0 || h <= 0) {
                std::cout<<"Dlugosc boków rombu i jego wysokosc musza byc wieksze od zera.";
                getValues();
            }else{
                outPut();
            }
        }
    }

    virtual double field(double a, double h) const {
        return a * h;
    }

    virtual double obwod(double a) const {
        return 4*a;
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,h)<<"\nObwod: "<<obwod(a)<<std::endl;
    }
};

class Prostokat{
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
        	std::cout<<"\nPROSTOKAT";
            std::cout<<"\nPodaj bok A: "; std::cin>>a;
            std::cout<<"Podaj bok B: "; std::cin>>b;
            if (a <= 0 || b <= 0) {
                std::cout<<"Dlugosci boków prostokata musza byc wieksze od zera."<<std::endl;
                getValues();
            }else{
                outPut();
            }
        }
    }

    virtual double field(double a,double b) const {
        return a * b;
    }

    virtual double obwod(double a,double b) const {
        return 2 * (a + b);
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,b)<<"\nObwod: "<<obwod(a,b)<<std::endl;
    }
};

class Rownoleglobok{
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
        	std::cout<<"\nROWNOLEGLOBOK";
            std::cout<<"\nPodaj bok A: "; std::cin>>a;
            std::cout<<"Podaj bok B: "; std::cin>>b;
            std::cout<<"Podaj bok H: "; std::cin>>h;
            if (a <= 0 || b <= 0 || h <= 0) {
                std::cout<<"Dlugosci boków równolegloboku i jego wysokosc musza byc wieksze od zera."<<std::endl;
                getValues();
            }else{
                outPut();
            }
        }
    }

    virtual double field(double a,double h) const {
        return a * h;
    }

    virtual double obwod(double a,double b) const {
        return 2 * (a + b);
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,h)<<"\nObwod: "<<obwod(a,b)<<std::endl;
    }
};

class Trapez{
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
        	std::cout<<"\nTRAPEZ";
            std::cout<<"\nPodaj bok A: "; std::cin>>a;
            std::cout<<"Podaj bok B: "; std::cin>>b;
            std::cout<<"Podaj bok C: "; std::cin>>c;
            std::cout<<"Podaj bok D: "; std::cin>>d;
            std::cout<<"Podaj bok H: "; std::cin>>h;
            if(a <= 0 || b <= 0 || c <= 0 || d <= 0 || h <= 0){
                std::cout<<"Dlugosci boków trapezu i jego wysokosc musza byc wieksze od zera."<<std::endl;
                getValues();
            }else{
                outPut();
            }
        }
    }

    virtual double field(double a,double b,double h) const {
        return 0.5 * (a + b) * h;
    }

    virtual double obwod(double a,double b,double c,double d) const {
        return a + b + c + d;
    }

    void outPut(){
        std::cout<<"\nPole: "<<field(a,b,h)<<"\nObwod: "<<obwod(a,b,c,d)<<std::endl;
    }
};

int main()
{
	Kwadrat kwadrat;
	kwadrat.getValues();

	Romb romb;
	romb.getValues();

	Prostokat prostokat;
	prostokat.getValues();

	Rownoleglobok rownoleglobok;
	rownoleglobok.getValues();

	Trapez trapez;
	trapez.getValues();

	Figura figura;
	figura.getValues();

    return 0;
}
