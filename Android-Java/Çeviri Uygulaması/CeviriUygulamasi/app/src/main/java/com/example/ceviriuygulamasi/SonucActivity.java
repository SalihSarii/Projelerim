package com.example.ceviriuygulamasi;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.lifecycle.ViewModelProvider;
import androidx.viewpager2.widget.ViewPager2;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;

import com.google.android.material.tabs.TabLayout;

public class SonucActivity extends AppCompatActivity {

    TabLayout tabLayout;
    ViewPager2 viewPager2;
    MyViewPagerAdapter myViewPagerAdapter;
    String arananKelime="";
    private veritabani vr;

    SharedPreferences sp;

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {//Menü bağlanmış oldu
        getMenuInflater().inflate(R.menu.menu_sonuc,menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.sonuc_geri:
                Intent anaIntent = new Intent(getApplicationContext(),AnasayfaaActivity.class);
                startActivity(anaIntent);
                break;
            case R.id.sonuc_info:
                Toast.makeText(getApplicationContext(),"Cambridge ingilizce anlam sayfasıdır.",Toast.LENGTH_LONG).show();
                break;
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sonuc);

        vr =  new veritabani(SonucActivity.this);
        arananKelime=vr.sonKelimeOku();

        //Fragmentlara veri göndermek için kullanıyoruz
        sp = getSharedPreferences("Kelimem", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor= sp.edit();
        editor.putString("kelime",arananKelime);
        editor.commit();



        tabLayout = findViewById(R.id.tabLayout);
        viewPager2 = findViewById(R.id.viewPager);

        myViewPagerAdapter= new MyViewPagerAdapter(this);
        viewPager2.setAdapter(myViewPagerAdapter);

        tabLayout.addOnTabSelectedListener(new TabLayout.OnTabSelectedListener() {
            @Override
            public void onTabSelected(TabLayout.Tab tab) {
                viewPager2.setCurrentItem(tab.getPosition());
            }

            @Override
            public void onTabUnselected(TabLayout.Tab tab) {

            }

            @Override
            public void onTabReselected(TabLayout.Tab tab) {

            }
        });

        viewPager2.registerOnPageChangeCallback(new ViewPager2.OnPageChangeCallback() {
            @Override
            public void onPageSelected(int position) {
                super.onPageSelected(position);
                tabLayout.getTabAt(position).select();
            }
        });
    }
}