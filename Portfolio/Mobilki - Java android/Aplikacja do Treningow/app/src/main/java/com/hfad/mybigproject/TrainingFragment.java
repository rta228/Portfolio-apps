package com.hfad.mybigproject;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

public class TrainingFragment extends Fragment {
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        RecyclerView trainingRecycler = (RecyclerView) inflater.inflate(
                R.layout.fragment_diet, container, false);

        String[] trainingName = new String[Training.trainings.length];
        for (int i = 0; i < trainingName.length; i++) {
            trainingName[i] = Training.trainings[i].getName();
        }

        int[] trainingImages = new int[Training.trainings.length];
        for (int i = 0; i < trainingImages.length; i++) {
            trainingImages[i] = Training.trainings[i].getImageResourceId();
        }

        CaptionedImagesAdapter adapter =
                new CaptionedImagesAdapter(trainingName, trainingImages);
        trainingRecycler.setAdapter(adapter);
        GridLayoutManager layoutManager = new GridLayoutManager(getActivity(), 2);
        trainingRecycler.setLayoutManager(layoutManager);
        adapter.setListener(new CaptionedImagesAdapter.Listener() {
            public void onClick(int position) {
                Intent intent = new Intent(getActivity(), TrainingPlanActivity.class);
                intent.putExtra(TrainingPlanActivity.EXTRA_WORKOUT_ID, position);
                getActivity().startActivity(intent);
            }
        });
        return trainingRecycler;
    }
}
