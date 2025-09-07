package com.hfad.mybigproject;

public class Diet {
    private String name;
    private int imageResourceId;

    public static final Diet[] diets = {
            new Diet("Sniadanie", R.drawable.breakfast),
            new Diet("Drugie Sniadanie", R.drawable.secondbreakfast),
            new Diet("Obiad", R.drawable.dinner),
            new Diet("Podwieczorek", R.drawable.beforenightsnack),
            new Diet("Kolacja", R.drawable.lunch),
            new Diet("Przekaska", R.drawable.snack)
    };
    private Diet(String name, int imageResourceId) {
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
