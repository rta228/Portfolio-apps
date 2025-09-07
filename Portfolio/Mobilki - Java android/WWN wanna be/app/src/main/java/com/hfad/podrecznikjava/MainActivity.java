package com.hfad.podrecznikjava;

import static java.lang.Integer.parseInt;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    /* Bardzo wazne - jesli bedzieszc robic dodatkowe widoki musisz to wpisac do pierwszego layout np <androidx.constraintlayout.widget.ConstraintLayout xm w kazdym pliku
        xmlns:tools="http://schemas.android.com/tools"
        tools:context=".MainActivity"
    */

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main); // Tutaj masz sciage do zmiany widoku. Zeby stworzyc layout musisz wejsc w res - layout i tam utworzyc new layout file
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> { // A tutaj jakbys zapomniala masz finviewbyid sciage
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    public void changeTheScreen(View view) {
        switch(parseInt(view.getTag().toString())){
            case 1:
                setContentView(R.layout.zadanie1);
                break;
            case 2:
                setContentView(R.layout.zadanie2);
                break;
            case 3:
                setContentView(R.layout.zadanie3);
                break;
            case 4:
                setContentView(R.layout.zadanie4);
                break;
            case 5:
                setContentView(R.layout.zadanie5);
                break;
            case 6:
                setContentView(R.layout.zadanie6);
                break;
            case 7:
                setContentView(R.layout.zadanie7);
                break;
            case 8:
                setContentView(R.layout.zadanie8);
                break;
        }
    }

    // Zadanie 1
    public int zad1LiczbaPolubien = 0;
    public void zad1Polub(View view){
        zad1LiczbaPolubien++;
        // Lub  zad1LiczbaPolubien+=1;
        zad1ZmienPolubienia();
    }

    public void zad1Usun(View view){
        if((zad1LiczbaPolubien-1)>=0){
            zad1LiczbaPolubien--;
        }
        zad1ZmienPolubienia();
    }

    public void zad1ZmienPolubienia(){
        TextView zad1PulbieniaTextView = findViewById(R.id.zad1polubienia);
        zad1PulbieniaTextView.setText(zad1LiczbaPolubien+" polubien");
    }


    //Zadanie 2
    public void zad2zatwierdzWszystko(View view){
        TextView zad2email = findViewById(R.id.zad2emailinput);
        TextView zad2haslo = findViewById(R.id.zad2haslo1input);
        TextView zad2hasloPowt = findViewById(R.id.zad2haslo2input);
        TextView zad2Wynik = findViewById(R.id.zad2wiadomosc);

        if(zad2email.getText().toString().contains("@")){
            if(zad2haslo.getText().toString().equals(zad2hasloPowt.getText().toString())){
                zad2Wynik.setText("Witaj "+zad2email.getText());
            }else{
                zad2Wynik.setText("Hasła się różnią");
            }
        }else{
            zad2Wynik.setText("Nieprawidłowy adres e-mail");
        }
    }

    //Zadanie 3
    
    public void zad3PrevFunction(View view) {

    }

    public void zad3NextFunction(View view) {

    }
}