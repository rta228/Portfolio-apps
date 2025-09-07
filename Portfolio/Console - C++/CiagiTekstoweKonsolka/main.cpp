#include <iostream>
using namespace std;
//zrob klase ktora bd tworzyla ramke wokol napisu, jesli napis bd dluzszy niz 80 znakow zrob go w wielu liniach;
/* Styl frame

 +-----------+
 | Napis Cos |
 +-----------+

*/
class Frame{
private:
    string tekst;

public:
    void setData(string pTekst){
        pTekst=tekst;
    }

    void frame(){
        int dlugosc;
        for(dlugosc= size(tekst);dlugosc>=0; dlugosc--){
            cout<<"s";
        }
    }

};

int main(){

return 0;
}
