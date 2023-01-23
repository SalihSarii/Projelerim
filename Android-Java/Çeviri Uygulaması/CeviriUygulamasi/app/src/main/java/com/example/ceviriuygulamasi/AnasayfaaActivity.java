package com.example.ceviriuygulamasi;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Calendar;
import java.util.Collections;

public class AnasayfaaActivity extends AppCompatActivity {
    Button btnAra;
    EditText txtAra;
    String araKelime="";
    String tarih="";
    ListView glistView;
    private veritabani v3 = new veritabani(this);
    private String[] gTarih;
    private String[] gecmisKelimeler;
    private gecmisAdapter gAdapter;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_anasayfaa);

        btnAra =(Button) findViewById(R.id.btnAra);
        txtAra=(EditText) findViewById(R.id.editTextAra) ;
        glistView=(ListView) findViewById(R.id.gListView);


        //Geçmişte aranan kelimeler veri tabanından çekildi
        gecmisKelimeler = v3.kelimeleriOku().get(0).clone();
        gTarih = v3.kelimeleriOku().get(1).clone();
        Collections.reverse(Arrays.asList(gecmisKelimeler));
        Collections.reverse(Arrays.asList(gTarih));

        //Veriler adapter'a veriliyor ve listview'e işleniyor
       gAdapter= new gecmisAdapter(gecmisKelimeler,gTarih,this);
        glistView.setAdapter(gAdapter);


        //Ara butonuna basıldığında yapılacaklar
        btnAra.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                araKelime= txtAra.getText().toString();

                //Şu anki tarih ve saati alıyoruz.
                Calendar c = Calendar.getInstance();
                SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
                 tarih = sdf.format(c.getTime());

                if(!araKelime.isEmpty()){
                    v3.kelimeEkle(araKelime,tarih);
                    Intent intentAra = new Intent(getApplicationContext(),SonucActivity.class);
                    startActivity(intentAra);
                }
                else{
                    Toast.makeText(getApplicationContext(),"Lütfen bir kelime giriniz",Toast.LENGTH_SHORT).show();
                }

            }
        });
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_anasayfa,menu);
        return super.onCreateOptionsMenu(menu);
    }

    //Üstteki Menü işaretlerinin yapacağı işlemler
    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.anasayfa_info:
                Toast.makeText(getApplicationContext(),"Yalnizca ingilizceden türkçeye çeviri yapılmaktadır.",Toast.LENGTH_SHORT).show();
                break;
            case R.id.anasayfa_geri:
                Intent girisIntent = new Intent(getApplicationContext(),GirisActivity.class);
                startActivity(girisIntent);
                break;
        }

        return super.onOptionsItemSelected(item);
    }






}