package com.example.ceviriuygulamasi;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.Calendar;

public class GirisActivity extends AppCompatActivity {
    TextView textYenile;
    Button btnGiris;
    EditText txtSifre;
    private veritabani v2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_giris);

        v2 = new veritabani(GirisActivity.this);//context veriliyor

        //view'ler idleri ile çağrılıyorlar
        btnGiris =(Button) findViewById(R.id.btnGiris);
        textYenile=(TextView) findViewById(R.id.textViewYenile);
        txtSifre= (EditText) findViewById(R.id.editTextSifre);





    textYenile.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            Intent yenileIntent = new Intent(getApplicationContext(),SifreYenileActivity.class);
            startActivity(yenileIntent);
        }
    });

    btnGiris.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            Intent girisIntent = new Intent(getApplicationContext(),AnasayfaaActivity.class);

            String Sifree=  txtSifre.getText().toString(); //Sifre almak icin gerekli olanlar

            String sifreV= v2.sifreOku();

         //Şifre validasyon işlemleri
        if (Sifree.isEmpty()){
            Toast.makeText(getApplicationContext(),"Sifre Alanı Boş Geçilemez!",Toast.LENGTH_LONG).show();
        }
        else if(!Sifree.equals(sifreV)){
            Toast.makeText(getApplicationContext(),"Sifreyi yanlis girdiniz",Toast.LENGTH_LONG).show();
        }
        else{
            startActivity(girisIntent);
        }
        }
    });

    }


}

