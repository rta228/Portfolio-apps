package com.example.myapplication2;

import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    public int polubienia = 0;
    public int tab[] = {R.drawable.kot1, R.drawable.kot2, R.drawable.kot3, R.drawable.kot4,};
    int index=0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    public void prev(View view) {
        ImageView obraz = findViewById(R.id.obraz);

        if (index > 0) {
            index--;
        } else {
            index = tab.length - 1;
        }
        obraz.setImageResource(tab[index]);
    }
    public void next(View view) {
        ImageView obraz = findViewById(R.id.obraz);

        if (index < tab.length - 1) {
            index++;
        } else {
            index = 0;
        }
        obraz.setImageResource(tab[index]);
    }

    public void polub(View view) {
        TextView tekst = findViewById(R.id.tekst1);
        polubienia++;
        tekst.setText(polubienia + " polubień");
    }

    public void usun(View view) {
        TextView tekst = findViewById(R.id.tekst1);
        polubienia=0;
        tekst.setText(polubienia + " polubień");
    }

    public void zatwierdz(View view) {
        TextView mail = findViewById(R.id.Email);
        TextView haslo1 = findViewById(R.id.Password);
        TextView haslo2 = findViewById(R.id.Password2);
        String tekstMail = mail.getText().toString();
        String tekstHaslo1 = haslo1.getText().toString();
        String tekstHaslo2 = haslo2.getText().toString();
        TextView tekst2 = findViewById(R.id.tekst2);

        if(tekstMail.contains("@")){
            if(tekstHaslo1.equals(tekstHaslo2) && tekstHaslo1!=""){
                tekst2.setText("Witaj " + tekstMail);
            }else{
                tekst2.setText("Hasła są różne");
            }
        }else{
            tekst2.setText("Email jest niepoprawny");
        }
    }
}