package com.hfad.mybigproject;

public class Training {
    private String name;
    private int imageResourceId;

    public static final Training[] trainings = {
            new Training("FullBodyWorkout", R.drawable.fullbodyworkout),
            new Training("PushPullLeg", R.drawable.pushpullleg),
            new Training("ChestBackLeg", R.drawable.chestbackleg)
    };
    private Training(String name, int imageResourceId) {
        this.name = name;
        this.imageResourceId = imageResourceId;
    }
    public String getName() {
        return name;
    }
    public int getImageResourceId() {
        return imageResourceId;
    }
}