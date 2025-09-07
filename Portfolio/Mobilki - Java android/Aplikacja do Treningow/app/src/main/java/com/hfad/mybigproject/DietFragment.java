package com.hfad.mybigproject;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

public class DietFragment extends Fragment {
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        RecyclerView dietRecycler = (RecyclerView)inflater.inflate(
                R.layout.fragment_diet, container, false);

        String[] dietNames = new String[Diet.diets.length];
        for (int i = 0; i < dietNames.length; i++) {
            dietNames[i] = Diet.diets[i].getName();
        }

        int[] dietImages = new int[Diet.diets.length];
        for (int i = 0; i < dietImages.length; i++) {
            dietImages[i] = Diet.diets[i].getImageResourceId();
        }

        CaptionedImagesAdapter adapter =
                new CaptionedImagesAdapter(dietNames, dietImages);
        dietRecycler.setAdapter(adapter);
        GridLayoutManager layoutManager = new GridLayoutManager(getActivity(), 2);
        dietRecycler.setLayoutManager(layoutManager);
         adapter.setListener(new CaptionedImagesAdapter.Listener() {
           public void onClick(int position) {
                Intent intent = new Intent(getActivity(), GymDetailActivity.class);
                intent.putExtra(GymDetailActivity.EXTRA_DIET_ID, position);
                getActivity().startActivity(intent);
            }
        });
        return dietRecycler;
    }
}