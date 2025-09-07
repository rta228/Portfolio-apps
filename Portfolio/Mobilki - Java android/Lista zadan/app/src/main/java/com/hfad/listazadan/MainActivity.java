package com.hfad.listazadan;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ListView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    public String listaDoZrobienia[] = new String[]{
            "Zakupy: Chleb, Maslo, Ser",
            "Do zrobienia: Obiad, Umyc Podloge",
            "Weekend: Kino, Spacer z psem",
    };
    private int wielkoscTablicy = 3;
    private ListView listaView;
    private ArrayAdapter<String> arrayAdapter;
    private TextView textView;

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

        listaView = findViewById(R.id.listView1);

        arrayAdapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, listaDoZrobienia);

        listaView.setAdapter(arrayAdapter);
    }

    public void dodajNowyElement(View view) {
        textView = findViewById(R.id.editText);
        String nowyElement = textView.getText().toString();
        dodajElementTablicy(nowyElement);
    }

    public void dodajElementTablicy(String element){
        List arrayList = new ArrayList(Arrays.asList(listaDoZrobienia));

        arrayList.add(element);

        listaDoZrobienia = (String[]) arrayList.toArray(listaDoZrobienia);
        Log.d("NIGER", "dodajElementTablicy: "+listaDoZrobienia[3].toString());

        listaView = findViewById(R.id.listView1);
        arrayAdapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, listaDoZrobienia);
        listaView.setAdapter(arrayAdapter);
    };
}