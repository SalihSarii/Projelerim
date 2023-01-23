package com.example.ceviriuygulamasi;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;
import android.widget.Toast;

import androidx.activity.result.contract.ActivityResultContracts;

import java.util.LinkedList;
import java.util.List;

public class veritabani extends SQLiteOpenHelper {

    private static final String VERITABANI_ADI =  "kullaniciVerileri";
    private static final int SURUM = 1;
    SQLiteDatabase myDatabase;

    private static final String TABlO_ADI_SIFRE = "SIFRELER";
    private static final String ID_COL = "ID";
    private static final String SIFRE_COL ="SIFRE";

    private static final String TABLO_ADI_KELIME= "KELIMELER";
    private static final String ID_COL_KELIMELER = "ID";
    private static final String KELIME_COL = "KELIME";
    private static final String TARIH_COL = "TARIH";

    private Context myContext;


    public  veritabani(Context c){
        super(c,VERITABANI_ADI,null,SURUM);
        myContext=c;
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
    //Sifre tablosu ve kelimeler tablosu olusturuldu
        String sorgu="CREATE TABLE "+TABlO_ADI_SIFRE +" (" +ID_COL +" INTEGER PRIMARY KEY AUTOINCREMENT, "+SIFRE_COL+" TEXT)";
        String sorgu2="CREATE TABLE "+TABLO_ADI_KELIME+" ("+ID_COL_KELIMELER+" INTEGER PRIMARY KEY AUTOINCREMENT, "+KELIME_COL+" TEXT,"+TARIH_COL+" TEXT)";
        db.execSQL(sorgu);
        db.execSQL(sorgu2);
        Toast.makeText(myContext,"Veritabani eklenmiştir",Toast.LENGTH_SHORT).show();
    }



    public void sifreEkle(String sifre){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cvEkle = new ContentValues();

        cvEkle.put(SIFRE_COL,sifre);
        db.insert(TABlO_ADI_SIFRE,null,cvEkle);
        db.close();
    }

    public String sifreOku(){
        SQLiteDatabase db = this.getReadableDatabase();
        String sifrem="";
        Cursor cursorSifre = db.rawQuery("SELECT * FROM "+ TABlO_ADI_SIFRE,null);
        int sirano_Sifre = cursorSifre.getColumnIndex(SIFRE_COL);
        if(cursorSifre.moveToFirst()){
            sifrem= cursorSifre.getString(sirano_Sifre);
        }

        cursorSifre.close();
        db.close();
        return sifrem;

    }

    public void sifreGuncelle(String yeniSifre){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cvGuncelle = new ContentValues();

        cvGuncelle.put("Sifre",yeniSifre);
        String whereClause =ID_COL+"= 1";
        db.update(TABlO_ADI_SIFRE,cvGuncelle,whereClause,null);
        db.close();
    }

    public void kelimeEkle(String eKelime,String tarih){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cvEkleKelime= new ContentValues();

        cvEkleKelime.put(KELIME_COL,eKelime);
        cvEkleKelime.put(TARIH_COL,tarih);
        db.insert(TABLO_ADI_KELIME,null,cvEkleKelime);
        db.close();
    }

    public String sonKelimeOku(){
        SQLiteDatabase db=  this.getReadableDatabase();
        String kelimem="";
        Cursor cursorKelime =db.rawQuery("SELECT * FROM "+TABLO_ADI_KELIME,null);
        int sirano_Kelime = cursorKelime.getColumnIndex(KELIME_COL);
        if(cursorKelime.moveToLast()){
            kelimem=cursorKelime.getString(sirano_Kelime);
        }

        cursorKelime.close();
        db.close();

        return kelimem;
    }
    public List<String[]> kelimeleriOku(){
        SQLiteDatabase db = this.getReadableDatabase();
        List<String> kelimeList= new LinkedList<String>();
        List<String> tarihList= new LinkedList<String>();
        List<String[]> veriler = new LinkedList<>();
        String[] kelimeler ={"HİÇBİR VERİ GİRİLMEMİŞTİR","HİÇBİR VERİ GİRİLMEMİŞTİR"};
        String[] tarihler ={"HİÇBİR VERİ GİRİLMEMİŞTİR","HİÇBİR VERİ GİRİLMEMİŞTİR"};
        Cursor cursorKelime= db.rawQuery("SELECT * FROM "+TABLO_ADI_KELIME,null);

        int sirano_Kelime=cursorKelime.getColumnIndex(KELIME_COL);
        int sirano_Tarih=cursorKelime.getColumnIndex(TARIH_COL);


        while (cursorKelime.moveToNext()){
            kelimeList.add(cursorKelime.getString(sirano_Kelime));
            tarihList.add(cursorKelime.getString(sirano_Tarih));
        }

        if(!kelimeList.isEmpty()){
            kelimeler = kelimeList.toArray(new String[0]);
            tarihler = tarihList.toArray(new String[0]);
        }

        cursorKelime.close();
        db.close();
        veriler.add(kelimeler);
        veriler.add(tarihler);
        return veriler;
    }
    @Override
    public void onUpgrade(SQLiteDatabase db, int eskiversiyon, int yeniversiyon) {

        db.execSQL("DROP TABLE IF EXISTS tbl_Sifre");
        onCreate(db);
    }



    public void gecmisiSil(){
        SQLiteDatabase db= getWritableDatabase();
        String sorgu="DELETE FROM "+TABLO_ADI_KELIME;
        db.execSQL(sorgu);
        db.close();
    }
}


