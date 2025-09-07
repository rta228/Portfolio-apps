package com.hfad.mybigproject;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import androidx.appcompat.app.AppCompatActivity;

public class TrainingPlanActivity extends AppCompatActivity {

    public static final String EXTRA_WORKOUT_ID = "workout_id";
    private boolean[] checkedStates;
    private static final String CHECKED_STATES_KEY = "checked_states";



    private ListView exerciseListView;

    private String[][] workoutExercises = {
            {"Przysiady ze sztangą (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Hamster Curl (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Zciąganie drązka wyciągu górnego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wiosłowanie na maszynie / sztandze (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie sztangi na ławce prostej / skosie dodatnim (20 powtorzen na pustym, 3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie hantli nad glowe siedzac / Wzniosy ramion (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie ramion na linkach / drazku wyciagu gornego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Mlotki / Modlitewnik na sztandze lamanej (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)"},
            {"Push: ",
                    "Wyciskanie sztangi na ławce prostej (20 powtorzen na pustym, 3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie sztangi na ławce skosnej dodatniej (20 powtorzen na pustym, 3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie hantli na ławce skosnej dodatniej (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Rozpietki na bramie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Deepy (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie ramion na linkach wyciagu gornego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie ramion na drazku wyciagu gornego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie hantli nad glowe siedzac (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie nad glowe na maszynie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",

                    "Pull: ",
                    "Zciąganie drązka wyciągu górnego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Podciaganie chwytem szerokim (4 serie do upadku miesniowego)",
                    "Wiosłowanie na maszynie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wiosłowanie na hantlach (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Face pull (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Mlotki (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Modlitewnik na sztandze lamanej (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Biceps na drazku wyciagu dolnego (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wzniosy ramion (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",

                    "Nogi: ",
                    "Przysiady ze sztangą (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Przysiady na suwnicy (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Hamster Curl (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie nóg (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Przysiady bulgarskie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wykroki (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)"
            },
            {"Dzien Klata|Triceps: ",
                    "Wyciskanie sztangi na ławce prostej (20 powtorzen na pustym, 3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie sztangi na ławce skosnej dodatniej (20 powtorzen na pustym, 3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie hantli na ławce skosnej dodatniej (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Rozpietki na bramie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Deepy (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie ramion na linkach wyciagu gornego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie ramion na drazku wyciagu gornego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",

            "Dzien Plecy|Biceps: ",
                    "Zciąganie drązka wyciągu górnego (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Podciaganie chwytem szerokim (4 serie do upadku miesniowego)",
                    "Wiosłowanie na maszynie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wiosłowanie na hantlach (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Mlotki (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Modlitewnik na sztandze lamanej (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Biceps na drazku wyciagu dolnego (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",

            "Dzien Nogi|Barki: ",
                    "Przysiady ze sztangą (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Przysiady na suwnicy (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Hamster Curl (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Prostowanie nóg (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie hantli nad glowe siedzac (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wyciskanie nad glowe na maszynie (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Wzniosy ramion (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",

            "Dzien Brzuch|Przedramiona {BONUS}: ",
                    "Zciaganie kolan do klatki lezac (3 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Russian twisty (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Plank (2 serie po 60 sek.)",
                    "HollowBody (2 serie po 60 sek.)",
                    "Wrist curl (2 serie po 12 powtórzeń)",
                    "Reverse wrist curls (2 serie po 12 powtórzeń)",
                    "Rotacja ramienia siedzac do wewnątrz oraz na zewnątrz (2 serie po 12 powtórzeń i 1 seria 14 powtórzeń)",
                    "Ulubione kardio (30 minut - interwaly 5 min intensywne -> 5 min luzne)"},

    };

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        if (exerciseListView != null && exerciseListView.getCount() > 0) {
            checkedStates = new boolean[exerciseListView.getCount()];
            for (int i = 0; i < exerciseListView.getCount(); i++) {
                checkedStates[i] = exerciseListView.isItemChecked(i);
            }
            outState.putBooleanArray(CHECKED_STATES_KEY, checkedStates);
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_training_plan);

        exerciseListView = findViewById(R.id.exercise_listview);

        int workoutId = getIntent().getIntExtra(EXTRA_WORKOUT_ID, 0);

        if (savedInstanceState != null) {
            checkedStates = savedInstanceState.getBooleanArray(CHECKED_STATES_KEY);
        }

        if (workoutId >= 0 && workoutId < workoutExercises.length) {
            String[] exercises = workoutExercises[workoutId];

            ArrayAdapter<String> adapter = new ArrayAdapter<>(this, R.layout.exercise_item, R.id.textViewExerciseName, exercises);
            exerciseListView.setAdapter(adapter);

            if (checkedStates != null && checkedStates.length == exercises.length) {
                for (int i = 0; i < checkedStates.length; i++) {
                    exerciseListView.setItemChecked(i, checkedStates[i]);
                }
            }
        }
    }

}
