package com.hfad.galeriazdjec;

import android.annotation.SuppressLint;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ImageView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

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
    // Deklaracje pol
    public int arrayOfImageIds[] = {
            R.drawable.zdjecie1,
            R.drawable.zdjecie2,
            R.drawable.zdjecie3,
            R.drawable.zdjecie4,
            R.drawable.zdjecie5,
            R.drawable.zdjecie6,
            R.drawable.zdjecie7,
            R.drawable.zdjecie8,
            R.drawable.zdjecie9,
            R.drawable.zdjecie10,
            R.drawable.zdjecie11,
            R.drawable.zdjecie12,
    };

    public int numberOfCurrentImage = 0;

    public void goBigFunction(View view) {
        setContentView(R.layout.big_image_layout);
        ImageView bigImage = findViewById(R.id.imageView14);
        numberOfCurrentImage = Integer.parseInt(view.getTag().toString())-1;
        bigImage.setImageDrawable(getDrawable(arrayOfImageIds[numberOfCurrentImage]));
    }

    public void goPrevFunction(View view) {
        ImageView bigImage = findViewById(R.id.imageView14);
        if(numberOfCurrentImage-1<0){
            numberOfCurrentImage=11;
        }else{
            numberOfCurrentImage--;
        }
        bigImage.setImageDrawable(getDrawable(arrayOfImageIds[numberOfCurrentImage]));
    }

    public void goNextFunction(View view) {
        ImageView bigImage = findViewById(R.id.imageView14);
        if(numberOfCurrentImage+1>11){
            numberOfCurrentImage=0;
        }else{
            numberOfCurrentImage++;
        }
        bigImage.setImageDrawable(getDrawable(arrayOfImageIds[numberOfCurrentImage]));
    }

    public void goSmallFunction(View view) {
        setContentView(R.layout.activity_main);
    }
}