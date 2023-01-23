package com.example.ceviriuygulamasi;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.util.Dictionary;

public class SifreYenileActivity extends AppCompatActivity {

    Button btnYenile;
    EditText eskiSifre;
    EditText yeniSifre;
    String Sifrem="";
    private veritabani v1;

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_yenile,menu);
        return super.onCreateOptionsMenu(menu);
    }

    //Giris ekranına dönmemizi sağlayan options menü işlemi
    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.yenile_geri:
                Intent girisIntent = new Intent(getApplicationContext(),GirisActivity.class);
                startActivity(girisIntent);
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sifre_yenile);

        v1= new veritabani(this);

        btnYenile =(Button) findViewById(R.id.buttonYenile);
        eskiSifre =(EditText) findViewById(R.id.editTextEski);
        yeniSifre =(EditText) findViewById(R.id.editTextYeni);

        btnYenile.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent gIntent = new Intent(getApplicationContext(),GirisActivity.class);

                //Veri tabanından şifre çekilme işlemi
                Sifrem= v1.sifreOku().toString();
                String yeniSifrem=yeniSifre.getText().toString();
                String eskiSifrem=eskiSifre.getText().toString();

                //Şifrenin güncellenmesi noktasında validasyon işlemleri
                if(eskiSifre.getText().toString().isEmpty() || yeniSifrem.isEmpty())
                {
                    Toast.makeText(SifreYenileActivity.this,"Lütfen boş yerleri doldurunuz.", Toast.LENGTH_SHORT).show();
                }
                else if(!eskiSifrem.equals(Sifrem)){
                    Toast.makeText(SifreYenileActivity.this, "Eski Sifrenizi Yanlış Girdiniz.\nLütfen Tekrar Deneyiniz..", Toast.LENGTH_SHORT).show();
                }
                else{
                    v1.sifreGuncelle(yeniSifrem);
                    Toast.makeText(SifreYenileActivity.this,"Sifre Güncellenmiştir",Toast.LENGTH_SHORT).show();
                    startActivity(gIntent);
                }



            }
        });
    }





}


