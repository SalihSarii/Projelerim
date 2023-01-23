package com.example.ceviriuygulamasi;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.viewpager2.adapter.FragmentStateAdapter;

public class MyViewPagerAdapter extends FragmentStateAdapter {

    public MyViewPagerAdapter(@NonNull FragmentActivity fragmentActivity) {
        super(fragmentActivity);
    }

    @NonNull
    @Override
    public Fragment createFragment(int position) {
        switch (position){
            case 0:
                return new fragmentTureng();
            case 1:
                return new fragmentGoogle();
            case 2:
                return new fragmentCambridge();
            default:
                return new fragmentTureng();
        }
    }

    @Override
    public int getItemCount() {
        return 3;
    }
}
