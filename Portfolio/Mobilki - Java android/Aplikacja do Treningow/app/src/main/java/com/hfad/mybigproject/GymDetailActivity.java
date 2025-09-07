package com.hfad.mybigproject;


import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.content.ContextCompat;

public class GymDetailActivity extends AppCompatActivity {

    public static final String EXTRA_WORKOUT_ID = "workout_id";
    public static final String EXTRA_DIET_ID = "diet_id";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_gym_detail);

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        ActionBar actionBar = getSupportActionBar();
        actionBar.setDisplayHomeAsUpEnabled(true);

        int workoutId = (Integer)getIntent().getExtras().get(EXTRA_WORKOUT_ID);
        String trainingName = Training.trainings[workoutId].getName();
        TextView textView = (TextView)findViewById(R.id.training_text);
        textView.setText(trainingName);
        int trainingImage = Training.trainings[workoutId].getImageResourceId();
        ImageView imageView = (ImageView)findViewById(R.id.training_image);
        imageView.setImageDrawable(ContextCompat.getDrawable(this, trainingImage));
        imageView.setContentDescription(trainingName);

        int dietId = (Integer)getIntent().getExtras().get(EXTRA_DIET_ID);
        String dietName = Diet.diets[dietId].getName();
        textView = (TextView) findViewById(R.id.training_text);
        textView.setText(dietName);
        int dietImage = Diet.diets[dietId].getImageResourceId();
        imageView = (ImageView) findViewById(R.id.training_image);
        imageView.setImageDrawable(ContextCompat.getDrawable(this, dietImage));
        imageView.setContentDescription(dietName);
    }
}